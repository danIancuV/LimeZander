import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { CategoriesComponent } from './categories/categories.component';


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
        component: HomeComponent
      },
      {
        path: 'rods',
        component: HomeComponent
      }
    ]
  }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
