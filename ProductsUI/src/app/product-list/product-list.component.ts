import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { Product} from '../product.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  productsList: Product[];

  constructor(private productService :ProductService, private router:Router) { }

  ngOnInit() {
    this.reloadData();
  }

  reloadData() {
    this.productService.getProductsList().subscribe(data=>{this.productsList=data;
      console.log(this.productsList); //get all products
      this.productsList.sort((x,y) => x.productId < y.productId ? -1 : 1)});
  }


}
