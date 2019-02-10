import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {HomeComponent} from './home/home.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'shopping-list', loadChildren: './shopping-list/shopping-list.module#ShoppingListModule' },
  { path: 'recipes', loadChildren: './recipes/recipes.module#RecipesModule' }
]

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})
export class  AppRoutingModule {
}
