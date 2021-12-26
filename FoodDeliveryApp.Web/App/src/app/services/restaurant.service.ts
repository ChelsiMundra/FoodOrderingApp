import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';

const resURL = "https://localhost:44355/api/restaurant";
@Injectable({
  providedIn: 'root'
})
export class RestaurantService {
  
  constructor(private http:HttpClient) { }

  getResList(): Observable<any> {
    return this.http.get(resURL);
  }
    
  getRestaurant(id): Observable<any> {
    return this.http.get(`${resURL}/${id}`);
  }

  create(data : Object): Observable<any> {
    return this.http.post(`${resURL}/add`, data);
  }

  delete(id): Observable<any> {
    
    return this.http.delete(`${resURL}/delete/${id}`);
  }

  update(id, data : Object ): Observable<any> {
    return this.http.put(`${resURL}/edit/${id}`, data);
  }

}
