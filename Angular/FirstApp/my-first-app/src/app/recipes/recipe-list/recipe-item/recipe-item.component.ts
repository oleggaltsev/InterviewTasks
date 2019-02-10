import {Component, OnInit, Input} from '@angular/core';
import {Recipe} from '../../recipe.model';
import {RecipeService} from '../../recipe.service';
import {ActivatedRoute, Params, Route, Router} from '@angular/router';

@Component({
  selector: 'app-recipe-item',
  templateUrl: './recipe-item.component.html',
  styleUrls: ['./recipe-item.component.css']
})
export class RecipeItemComponent implements OnInit {
  @Input() recipe: Recipe;
  constructor(
    private recipeService: RecipeService,
    private route: ActivatedRoute,
    private router: Router) { }
  ngOnInit() {}

  onItemSelected() {
      this.router.navigate(['/recipes', this.recipe.id]);
  }

  isActive(): boolean {
    const id = +this.route.snapshot.params['id'];

    this.route.params
      .subscribe(
        (params: Params) => {
          var id = this.recipeService.getRecipe(+params['id']);
        }
      );

    return id === this.recipe.id;
  }
}
