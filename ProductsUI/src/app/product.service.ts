import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product} from '../app/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private baseUrl = 'https://localhost:5001/api/products';
  constructor(private http: HttpClient) { }
  
  getProductsList(): Observable<Product[]> {
    return this.http.get<Product []>(`${this.baseUrl}`);
  }

  getProduct(id: number): Observable<Product> {
    return this.http.get<Product>(`${this.baseUrl}/${id}`);
  }
}
