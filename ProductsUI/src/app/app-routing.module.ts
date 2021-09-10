import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductListComponent } from '../app/product-list/product-list.component';
import { ViewProductComponent } from '../app/view-product/view-product.component';
import { FirstPageComponent } from '../app/first-page/first-page.component';

const routes: Routes = [
  { path: '', redirectTo: 'firstpage', pathMatch: 'full' },
  { path: 'firstpage', component: FirstPageComponent},
  { path: 'products',
  children: [{path:':productId',component: ViewProductComponent},
  {path: '', component: ProductListComponent}]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
