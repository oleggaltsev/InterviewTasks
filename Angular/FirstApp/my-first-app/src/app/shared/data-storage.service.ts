import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RecipeService } from '../recipes/recipe.service';
import { Recipe } from '../recipes/recipe.model';
import {map} from 'rxjs/operators';
import {AuthService} from '../auth/auth.service';


@Injectable()
export class DataStorageService {
  constructor(private httpClient: HttpClient,
              private recipeService: RecipeService,
              private authService: AuthService) {
  }

  saveData() {
    const data = this.recipeService.getRecipes();
    const token = this.authService.getToken();
    this.httpClient.put('https://shopping-list-c97c5.firebaseio.com/recipes.json?auth=' + token, data).subscribe();
  }

  fetchData() {
    const token = this.authService.getToken();
    this.httpClient.get<Recipe[]>('https://shopping-list-c97c5.firebaseio.com/recipes.json?auth=' + token)
      .pipe(map(
        (recipes) => {
          for (const item of recipes) {
            if (!item['ingredients']) {
              item['ingredients'] = [];
            }
          }
          return recipes;
        }
      ))
      .subscribe((recipes: Recipe[]) => {
        this.recipeService.setRecipes(recipes);
      });
  }
}
