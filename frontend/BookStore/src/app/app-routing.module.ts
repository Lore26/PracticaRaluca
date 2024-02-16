import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { BooksComponent } from './pages/books/books.component';
import { AddAuthorComponent } from './pages/add-author/add-author.component';
import { AddCategoryComponent } from './pages/add-category/add-category.component';
import { AddBookComponent } from './pages/add-book/add-book.component';

const routes: Routes = [
  { path:'#', component: HomeComponent},
  { path:'', component: HomeComponent},
  { path:'home', component: HomeComponent},
  { path:'books', component: BooksComponent},
  { path:'add-author', component: AddAuthorComponent},
  { path:'add-category', component: AddCategoryComponent},
  { path:'add-book', component: AddBookComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
