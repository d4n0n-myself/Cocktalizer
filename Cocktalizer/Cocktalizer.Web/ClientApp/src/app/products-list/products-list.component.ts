import {Component, OnInit} from '@angular/core';
import {HttpService} from "../services/httpService/http.service";
import {Product} from "../models/interfaces/product";

@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.css']
})
export class ProductsListComponent implements OnInit {
  products: Product[];

  constructor(private http: HttpService) {
  }

  ngOnInit() {
    this.http.getProducts().subscribe(result => {
      this.products = result;
    })
  }
}
