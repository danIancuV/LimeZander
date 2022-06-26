import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { CategoriesComponent } from './categories/categories.component';
import { ReelsComponent } from './products/reels/reels.component';
import { RodsComponent } from './products/rods/rods.component';
import { AccessoriesComponent } from './products/accessories/accessories.component';


const routes: Routes = [
  { path: '', 
    component: HomeComponent,
    children: [
      {
        path: '',
        redirectTo: 'categories',
        pathMatch: 'full',
      },
      {
        path: 'categories',
        component: CategoriesComponent
      },
      {
        path: 'reels',
        component: ReelsComponent
      },
      {
        path: 'rods',
        component: RodsComponent
      },
      {
        path: 'accessories',
        component: AccessoriesComponent
      }
    ]
  }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
