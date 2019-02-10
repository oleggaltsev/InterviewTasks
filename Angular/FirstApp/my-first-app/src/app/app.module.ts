import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {RecipesModule} from './recipes/recipes.module';
import {SharedModule} from './shared/shared.module';
import {AuthModule} from './auth/auth.module';
import {ShoppingListModule} from './shopping-list/shopping-list.module';
import { AppRoutingModule} from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { RecipeService} from './recipes/recipe.service';
import { ShoppingListService} from './shopping-list/shopping-list.service';
import { DataStorageService } from './shared/data-storage.service';
import {AuthService} from './auth/auth.service';
import {AuthGuard} from './auth/auth-guard.service';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AuthModule,
    SharedModule,
    AppRoutingModule
  ],
  providers: [RecipeService, ShoppingListService, DataStorageService, AuthService, AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
