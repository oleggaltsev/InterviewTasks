import {Recipe} from './recipe.model';
import {EventEmitter, Injectable} from '@angular/core';
import {Ingredient} from '../shared/ingredient.model';
import {ShoppingListService} from '../shopping-list/shopping-list.service';
import {Subject} from 'rxjs';
import 'lodash';
declare var _;

@Injectable()
export class RecipeService {
  recipesChanged = new Subject<Recipe[]>();

  private recipes: Recipe[] = [
    new Recipe(
      1,
      'A test description',
      'A Test Recipe',
      'https://static01.nyt.com/images/2015/08/14/dining/14ROASTEDSALMON/14ROASTEDSALMON-articleLarge.jpg',
      [
        new Ingredient(1, 'Apple', 2),
        new Ingredient(2, 'Cheese', 3),
        new Ingredient(3, 'Apple', 4),
        new Ingredient(4, 'Cheese', 5)
      ]),
    new Recipe(
      2,
      'B test description',
      'B Test Recipe',
      'https://static01.nyt.com/images/2015/08/14/dining/14ROASTEDSALMON/14ROASTEDSALMON-articleLarge.jpg',
      [
        new Ingredient(4, 'Apple 1', 6),
        new Ingredient(5, 'Cheese 1', 7),
      ]),
    new Recipe(
      3,
      'C test description',
      'C Test Recipe',
      'https://static01.nyt.com/images/2015/08/14/dining/14ROASTEDSALMON/14ROASTEDSALMON-articleLarge.jpg',
      [
        new Ingredient(8, 'Tomato', 12),
        new Ingredient(9,'Potato', 23),
      ])
  ];

  selectedItem = new EventEmitter<Recipe>();

  getRecipes() {
    return this.recipes.slice();
  }
  addRecipe(recipe: Recipe) {
    this.recipes.push(recipe);
    this.recipesChanged.next(this.recipes.slice());
  }
  updateRecipe(recipe: Recipe) {
    const item = this.getRecipeById(recipe.id);
    item.name = recipe.name;
    item.description = recipe.description;
    item.imagePath = recipe.imagePath;
    item.ingredients = recipe.ingredients;

    this.recipesChanged.next(this.recipes.slice());
  }

  getRecipeById(id: number) {
    return _.find(this.recipes, { id: id});
  }

  constructor(private shoppingListService: ShoppingListService) {}

  addIngredientsToShoppingList(ingredients: Ingredient[]) {
    this.shoppingListService.addIngredients(ingredients);
  }

  getRecipe(id: number) {
    const recipe = this.recipes.find(
      (s) => {
        return s.id === id;
      }
    );
    return recipe;
  }

  getNewRecipe() {
    return new Recipe(
      this.recipes.length + 1,
      '',
      '',
      '',
      []);
  }
  getNewIngredientId() {
    let i = 0;
    for (const item of this.recipes) {
      i += item.ingredients.length;
    }
    return ++i;
  }

  deleteById(id: number) {
    _.remove(this.recipes, function (n) {
      return n.id === id;
    });
    this.recipesChanged.next(this.recipes.slice());
  }

  setRecipes(recipes: Recipe[]) {
    this.recipes = recipes;
    this.recipesChanged.next(this.recipes.slice());
  }
}
