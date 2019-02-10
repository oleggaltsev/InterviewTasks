import {Ingredient} from '../shared/ingredient.model';
import {Subject} from 'rxjs';
import 'lodash';
declare var _;

export class ShoppingListService {

  ingredientAdded = new Subject<Ingredient[]>();
  startedEditing = new Subject<number>();

  private ingredients: Ingredient[] = [
    new Ingredient(1, 'Apples', 5),
    new Ingredient( 2, 'Tomato', 15)
  ];

  getIngredients() {
    return this.ingredients.slice();
  }
  addIngredient(ingredient: Ingredient) {
    this.ingredients.push(ingredient);
    this.ingredientAdded.next(this.ingredients.slice());
  }

  addIngredients(ingredients: Ingredient[]) {
    for (let item of ingredients) {
      this.ingredients.push(item);
    }
    this.ingredientAdded.next(this.ingredients.slice());
  }

  updateIngredient(ingredient: Ingredient) {
    const item = this.getIngredientById(ingredient.id);
    item.name = ingredient.name;
    item.amount = ingredient.amount;
    this.ingredientAdded.next(this.ingredients.slice());
  }

  getIngredientById(id: number) {
    return _.find(this.ingredients, { id: id});
  }

  deleteById(id: number) {
    _.remove(this.ingredients, function (n) {
      return n.id === id;
    });
    this.ingredientAdded.next(this.ingredients.slice());
  }
}
