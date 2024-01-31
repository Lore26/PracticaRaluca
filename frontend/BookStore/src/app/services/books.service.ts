import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Book } from '../entity/Book';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http: HttpClient) { }
  
  getBooks(): Observable<Book[]>{
    return this.http.get<Book[]>("https://localhost:7114/GetBooks");  
  }
}
