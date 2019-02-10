import {Component, OnInit} from '@angular/core';
import {Recipe} from '../recipe.model';
import {RecipeService} from '../recipe.service';
import {ActivatedRoute, Data, Params, Router} from '@angular/router';

@Component({
  selector: 'app-recipes-detail',
  templateUrl: './recipe-detail.component.html',
  styleUrls: ['./recipe-detail.component.css']
})
export class RecipeDetailComponent implements OnInit {
  selectedItem: Recipe;
  constructor(
    private recipeService: RecipeService,
    private route: ActivatedRoute,
    private router: Router) { }
  ngOnInit() {

     this.route.params
       .subscribe(
         (params: Params) => {
           this.selectedItem = this.recipeService.getRecipe(+params['id']);
         }
       );
  }

  onAddIngredients() {
    this.recipeService.addIngredientsToShoppingList(this.selectedItem.ingredients);
  }

  onDelete() {
    this.recipeService.deleteById(this.selectedItem.id);
    this.router.navigate(['/recipes']);
  }
}
