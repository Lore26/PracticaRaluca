import { Component, ElementRef, HostListener, ViewChild } from '@angular/core';
import { MatMenu } from '@angular/material/menu';
import { Category } from '../entity/Category';
import { CategoriesService } from '../services/categories.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  @ViewChild('menu') menu!: MatMenu;
  constructor(private elementRef: ElementRef, private categoriesService: CategoriesService) { }
  isClicked = false;
  handleClick() {
    this.isClicked = true;
  }

  @HostListener('document:click', ['$event.target'])
  onClickOutside(targetElement: any) {
    const isClickedOutside = !this.elementRef.nativeElement.contains(targetElement);

    if (isClickedOutside) {
      this.isClicked = false;
    }
  }
  categories: Category[] = [];

  async ngOnInit() {
    this.categoriesService.getCategories().subscribe((category) =>{
      this.categories = category;
      this.categories = [...this.categories].sort((a, b) => a.category_name.localeCompare(b.category_name));
    }); 
  }
}
