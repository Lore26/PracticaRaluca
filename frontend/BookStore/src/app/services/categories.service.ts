import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from '../entity/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  constructor(private http: HttpClient) { }

  getCategories(): Observable<Category[]>{
    return this.http.get<Category[]>("https://localhost:7114/GetCategories");  
  }
}