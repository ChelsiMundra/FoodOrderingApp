import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router'
import { AppComponent } from './app.component';
import { DishComponent } from './dish/dish.component';
import { CategoryComponent } from './category/category.component';
import { AddEditDishComponent } from './dish/add-edit-dish/add-edit-dish.component';
import { AddEditCategoryComponent } from './category/add-edit-category/add-edit-category.component';
import { ShowDishComponent } from './dish/show-dish/show-dish.component';

//import { Listyourcomponent} from './your/list-yours'
import { RestaurantComponent } from './restaurant/restaurant.component';
import { ShowResComponent } from './Restaurant/show-res/show-res.component';
import { AddEditResComponent } from './Restaurant/add-edit-res/add-edit-res.component';
import { SingleResComponent } from './Restaurant/single-res/single-res.component';

const appRoutes: Routes = [
  //{path: 'list' , component:Listyourcomponent }
 // { path: '', component: AppComponent },
  { path: 'dish', component: DishComponent },
  { path: 'category', component: CategoryComponent },
  { path: 'app-add-edit-category', component: AddEditCategoryComponent },
  { path: 'editcategory/:id', component: AddEditCategoryComponent },
  { path: 'add-edit-dish', component: AddEditDishComponent },
  { path: 'editdish/:id', component: AddEditDishComponent },
  { path: 'show-dish', component: ShowDishComponent },

  { path: 'restaurant', component:RestaurantComponent },
  { path: 'restaurant/details/:id', component:SingleResComponent},
  { path: 'restaurant/add/0',component:AddEditResComponent},
  { path: 'restaurant/update/:id',component:AddEditResComponent},
  { path: 'restaurant/showres',component:ShowResComponent}
]

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(appRoutes),
    CommonModule
  ],
  exports: [RouterModule]
})

export class AppRoutingModule { }
