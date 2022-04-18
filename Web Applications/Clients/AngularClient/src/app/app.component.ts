import { Component, OnInit } from '@angular/core';
import { Product } from './models/product.model';
import { ProductServiceService } from './product-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  constructor(private service:ProductServiceService){

  }
  title = 'AngularClient';
  products: Product[];

  ngOnInit(): void {
    this.service.getProducts().subscribe(data => {
      this.products = data;
      console.log(this.products);
    });
  }


}
