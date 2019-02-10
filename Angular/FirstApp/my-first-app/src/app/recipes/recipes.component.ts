import {Component, OnDestroy, OnInit} from '@angular/core';
import {RecipeService} from './recipe.service';
import {Recipe} from './recipe.model';
import {Subscription} from 'rxjs';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit, OnDestroy {
  selectedItem: Recipe;
  private subscription: Subscription;
  constructor(private recipeService: RecipeService) { }

  ngOnInit() {
    this.subscription = this.recipeService.selectedItem.subscribe((recipe: Recipe) => {
      this.selectedItem = recipe;
    });
  }

  ngOnDestroy(): void {
    this.subscription.unsubscribe();
  }
}
