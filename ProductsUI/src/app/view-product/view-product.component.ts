import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import { Product} from '../product.model';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-view-product',
  templateUrl: './view-product.component.html',
  styleUrls: ['./view-product.component.css']
})
export class ViewProductComponent implements OnInit {

  private product:Product;
  constructor(private productService:ProductService, private router:Router, 
    private route:ActivatedRoute) { }

  ngOnInit() {
    let id:number;
    this.route.params.subscribe(params=>id=+params['productId']);
    console.log(id);
    this.productService.getProduct(id).subscribe(data=>this.product=data);
  }

}
