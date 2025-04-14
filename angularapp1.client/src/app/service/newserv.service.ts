import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class NewservService {

  constructor(private http: HttpClient) { }


  getAllProducts() {

    return this.http.get('https://localhost:7244/api/Product/GetAllProducts')


  }


  getproductbyid(id :any) {

    return this.http.get(`https://localhost:7244/api/Product/GetProductById/${id}`)


  }
}
