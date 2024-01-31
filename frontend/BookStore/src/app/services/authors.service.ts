import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Author } from '../entity/Author';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthorsService {

  constructor(private http: HttpClient) { }

  getAuthors(): Observable<Author[]>{
    return this.http.get<Author[]>("https://localhost:7114/GetAuthors");  
  }
}
