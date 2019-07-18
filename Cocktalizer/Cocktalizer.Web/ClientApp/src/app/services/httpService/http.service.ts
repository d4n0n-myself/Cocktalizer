import {Inject, Injectable} from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs";
import {Product} from "../../models/interfaces/product";

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  baseUrl = 'http://localhost:5000';
  constructor(private http: HttpClient) {

  }

  getProducts() : Observable<Product[]> {
    return this.http.get<Product[]>(`${this.baseUrl}/Product/Get`);
  }
}
