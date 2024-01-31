import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Author } from 'src/app/entity/Author';
import { Book } from 'src/app/entity/Book';
import { AuthorsService } from 'src/app/services/authors.service';
import { BooksService } from 'src/app/services/books.service';


@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit{
  books: Book[] = [];
  authors: Author[] = [];
  
  constructor(private http: HttpClient, private booksService: BooksService, private authorsService: AuthorsService ){}
  
  async ngOnInit() {
    this.booksService.getBooks().subscribe((book) =>{
      this.books = book;
      console.log(this.books);
    });
    this.authorsService.getAuthors().subscribe((author) =>{
      this.authors = author;
    }); 
  }       
}