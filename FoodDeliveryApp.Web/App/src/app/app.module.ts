import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DishService } from './services/dish.service';
import { DishComponent } from './dish/dish.component';
import { ShowDishComponent } from './dish/show-dish/show-dish.component';
import { AddEditDishComponent } from './dish/add-edit-dish/add-edit-dish.component';
import { CategoryComponent } from './category/category.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AddEditCategoryComponent } from './category/add-edit-category/add-edit-category.component';
import { ShowCategoryComponent } from './category/show-category/show-category.component';


import { RestaurantComponent } from './restaurant/restaurant.component';
import { ShowResComponent } from './Restaurant/show-res/show-res.component';
import { AddEditResComponent } from './Restaurant/add-edit-res/add-edit-res.component';
import {RestaurantService} from './services/restaurant.service';
import { SingleResComponent } from './Restaurant/single-res/single-res.component'

@NgModule({
  declarations: [
    AppComponent,
    DishComponent,
    ShowDishComponent,
    AddEditDishComponent,
    CategoryComponent,
    AddEditCategoryComponent,
    ShowCategoryComponent,
    RestaurantComponent,
    ShowResComponent,
    AddEditResComponent,
    SingleResComponent,
    
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    NgbModule,

   
    ],
    providers: [DishService, RestaurantService],
    bootstrap: [AppComponent]
})
export class AppModule { }
