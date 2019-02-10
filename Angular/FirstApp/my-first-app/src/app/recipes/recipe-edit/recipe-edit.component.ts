import { Component, OnInit } from '@angular/core';
import {ActivatedRoute, Params, Router} from '@angular/router';
import {FormArray, FormControl, FormGroup, PatternValidator, Validators} from '@angular/forms';
import {RecipeService} from '../recipe.service';
import 'lodash';
declare var _;

@Component({
  selector: 'app-recipe-edit',
  templateUrl: './recipe-edit.component.html',
  styleUrls: ['./recipe-edit.component.css']
})
export class RecipeEditComponent implements OnInit {
  id: number;
  editMode = false;
  recipeForm: FormGroup;
  constructor(
    private route: ActivatedRoute,
    private recipeService: RecipeService,
    private router: Router) { }

  ngOnInit() {
    this.route.params.subscribe(
      (params: Params) => {
        this.id = +params['id'];
        this.editMode = params['id'] != null;
        this.intiForm();
      }
    );
  }

  onSubmit() {
    if (this.editMode) {
      this.recipeService.updateRecipe(this.recipeForm.value);
    } else {
      this.recipeService.addRecipe(this.recipeForm.value);
    }
    this.router.navigate(['../../'], {relativeTo: this.route});
  }

  onCancel() {
    this.router.navigate(['../../'], {relativeTo: this.route});
  }

  getControls() {
    return (<FormArray>this.recipeForm.get('ingredients')).controls;
  }

  addNewIngredient() {
    (<FormArray>this.recipeForm.get('ingredients')).push(
      new FormGroup({
        'id': new FormControl(this.recipeService.getNewIngredientId()),
        'name': new FormControl(null, Validators.required),
        'amount': new FormControl(null, [
          Validators.required,
          Validators.pattern(/^[1-9]+[0-9]*$/)
        ])
      })
    );
  }

  onDeleteIngredient(index: number) {
    (<FormArray>this.recipeForm.get('ingredients')).removeAt(index);
  }

  private intiForm() {
    let localRecipe = this.recipeService.getNewRecipe();
    const localRecipeIngredients = new FormArray([]);
    if (this.editMode) {
      localRecipe = this.recipeService.getRecipe(this.id);
      for (const item of localRecipe.ingredients) {
        localRecipeIngredients.push(new FormGroup({
          'id': new FormControl(item.id),
          'name': new FormControl(item.name, Validators.required),
          'amount': new FormControl(item.amount, [
            Validators.required,
            Validators.pattern(/^[1-9]+[0-9]*$/)
          ])
        }));
      }
    }

    this.recipeForm = new FormGroup({
      'id': new FormControl(localRecipe.id),
      'name': new FormControl(localRecipe.name, Validators.required),
      'imagePath': new FormControl(localRecipe.imagePath, Validators.required),
      'description': new FormControl(localRecipe.description, Validators.required),
      'ingredients': localRecipeIngredients
    });
  }
}
