import { Component, OnInit } from '@angular/core';
import { DishService } from '../../services/dish.service';
import { ActivatedRoute, Router } from '@angular/router'


@Component({
  selector: 'app-show-category',
  templateUrl: './show-category.component.html',
  styleUrls: ['./show-category.component.css']
})
export class ShowCategoryComponent implements OnInit {


  constructor(private dishservice: DishService, private router: Router) { }
  CategoryList: any;
  ngOnInit(): void {
    this.GetAllCategories();
  }

  deleteClick(item) {
    if (confirm('Are you sure you want to delete this category?')) {
      this.dishservice.deleteC(item.Id).subscribe(data => {
       // alert(data.toString());
        this.GetAllCategories();
        this.router.navigate(['./category']);
      },
        error => (console.log(error)))
    }
  }

  GetAllCategories() {
    this.dishservice.getCategoryList().subscribe(data => {
      this.CategoryList = data;
    },
    error => (console.log(error)));

  }

}
