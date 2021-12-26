import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators,  } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { DishService } from '../../services/dish.service';

@Component({
  selector: 'app-add-edit-category',
  templateUrl: './add-edit-category.component.html',
  styleUrls: ['./add-edit-category.component.css']
})

export class AddEditCategoryComponent implements OnInit {
  CategoryList: any;
  Id: number=0;
  ButtonName: string;
  CategoryForm: FormGroup;

  constructor(private dishservice: DishService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.Id = +this.route.snapshot.paramMap.get('id')
    if (this.Id != 0) {
      this.ButtonName = "Save Category";
      this.dishservice.getC(this.Id).subscribe(data => {
        this.CategoryForm = new FormGroup({
          CategoryName: new FormControl(data['CategoryName'], Validators.required),
        })
      })
    }
    else {
      this.ButtonName = "Add Category";
      this.CategoryForm = new FormGroup({
        CategoryName: new FormControl('', Validators.required),
      })
    }
  }



  OnSubmit() {
    if (this.Id==0) {
      const category = this.CategoryForm.value;
      this.Insert(category);
    }
    else {

      const item = this.CategoryForm.value;
      this.update(this.Id, item);
    }
    alert(JSON.stringify(this.CategoryForm.value));

  }

  update(id: any, item: any) {
    id = this.Id;
    this.dishservice.updateC(id, item).subscribe(() => {
      this.GetAllCategories();
    },
      error => (console.log(error)));

  }

  Insert(category: any) {
    this.dishservice.createC(category).subscribe(() => {
      this.GetAllCategories();
    },
      error => (console.log(error)));

  }


  deleteClick(item) {
    if (confirm('Are you sure you want to delete this category?')) {
      this.dishservice.deleteC(item.Id).subscribe(data => {
        alert(data.toString());
        this.GetAllCategories();
      },
        error => (console.log(error)))
    }
  }

  GetAllCategories() {
    this.dishservice.getCategoryList().subscribe(data => {
      this.CategoryList = data;
      this.router.navigate(['./category']);
    },
      error => (console.log(error)));

  }

  
}
