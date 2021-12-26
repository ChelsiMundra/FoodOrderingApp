import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

const dishURL = "https://localhost:44355/api/dish";
const categoryURL = "https://localhost:44355/api/category";
@Injectable({
  providedIn: 'root'
})
export class DishService {
  
  constructor(private http: HttpClient) { }

  getDishList(): Observable<any> {
    return this.http.get(dishURL);
  }
    
  get(id): Observable<any> {
    return this.http.get(`${dishURL}/${id}`);
  }

  create(data): Observable<any> {
    return this.http.post(dishURL, data);
  }

  delete(id): Observable<any> {
    return this.http.delete(`${dishURL}/delete/${id}`);
  }

  update(id, data): Observable<any> {
    return this.http.put(`${dishURL}/edit/${id}`, data);
  }


  getCategoryList(): Observable<any> {
    return this.http.get(categoryURL);
  }

  getC(id): Observable<any> {
    return this.http.get(`${categoryURL}/${id}`);
  }

  createC(data): Observable<any> {
    return this.http.post(categoryURL, data);
  }

  deleteC(id): Observable<any> {
    return this.http.delete(`${categoryURL}/delete/${id}`);
  }

  updateC(id, data): Observable<any> {
    return this.http.put(`${categoryURL}/edit/${id}`, data);
  }

}
