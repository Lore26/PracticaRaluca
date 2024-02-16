import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Book } from '../entity/Book';
import { ApiService } from './http/api.service';

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private apiService: ApiService) { }
  
  getBooks(): Observable<Book[]>{
    return this.apiService.get(['GetBooks']);  
  }
  addBook(book: Book): Observable<any> {
    return this.apiService.post(['AddBook'], book);
  }
}
