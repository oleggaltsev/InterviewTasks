import {NgModule} from '@angular/core';
import {PreloadAllModules, RouterModule, Routes} from '@angular/router';
import {AuthGuard} from './auth/auth-guard.service';
import {HomeComponent} from './core/home/home.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'shopping-list', loadChildren: './shopping-list/shopping-list.module#ShoppingListModule'/*, canLoad: [AuthGuard], canActivate: [AuthGuard]*/},
  { path: 'recipes', loadChildren: './recipes/recipes.module#RecipesModule'/*, canLoad: [AuthGuard], canActivate: [AuthGuard]*/ }
]

@NgModule({
  imports: [RouterModule.forRoot(appRoutes, {
    preloadingStrategy: PreloadAllModules
  })],
  exports: [RouterModule]
})
export class  AppRoutingModule {
}
