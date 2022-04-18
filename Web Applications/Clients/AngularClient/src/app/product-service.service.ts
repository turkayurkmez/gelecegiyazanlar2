import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from './models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductServiceService {

  constructor(private httpClient: HttpClient) { }

  getProducts():Observable<Product[]> {
    return this.httpClient.get<Product[]>('https://localhost:44333/api/Products');

  }
}
