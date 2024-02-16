import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Book } from 'src/app/entity/Book';
import { BooksService } from 'src/app/services/books.service';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent {
  constructor(private booksService: BooksService){}
  addBook(newForm: NgForm) {
    let book: Book = newForm.value;
    if (newForm.value.review_id == "") {
      book.review_id = null;
  }
    this.booksService.addBook(book).subscribe(newBook=>{
      newBook = book;
    });
  }
}