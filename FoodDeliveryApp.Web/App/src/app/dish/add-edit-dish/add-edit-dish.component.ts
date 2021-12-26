import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { DishService } from '../../services/dish.service';

@Component({
  selector: 'app-add-edit-dish',
  templateUrl: './add-edit-dish.component.html',
  styleUrls: ['./add-edit-dish.component.css']
})

export class AddEditDishComponent implements OnInit {
  DishList: any;
  Id: number = 0
  ButtonName: string;
  DishForm: FormGroup;

  constructor(private dishservice: DishService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.Id = +this.route.snapshot.paramMap.get('id')
    console.log(this.Id);
    if (this.Id != 0) {
      this.ButtonName = "Save Dish";
      this.dishservice.get(this.Id).subscribe(data => {
        this.DishForm = new FormGroup({
          DishName: new FormControl(data['DishName']),
          CategoryId: new FormControl(data['CategoryId']),
          Price: new FormControl(data['Price']),
          Description: new FormControl(data['Description'])
        })
      })
    }
    else {
      this.ButtonName = "Add Dish";
      this.DishForm = new FormGroup({
        DishName: new FormControl('', Validators.required),
        CategoryId: new FormControl('', Validators.required),
        Price: new FormControl('', Validators.required),
        Description: new FormControl('',Validators.required)
      })
    }
  }



  OnSubmit() {
    if (this.Id == 0) {
      const dish = this.DishForm.value;
      this.Insert(dish);
    }
    else {
      const item = this.DishForm.value;
      this.update(this.Id, item);
    }
    alert(JSON.stringify(this.DishForm.value));
    this.router.navigate(['./add-edit-dish']);

  }
  
  update(id: any, item: any) {
    id = this.Id;
    this.dishservice.update(id, item).subscribe(() => {
      this.GetAllDishes();
    },
      error => (console.log(error)));
  }

  Insert(dish: any) {
    this.dishservice.create(dish).subscribe(() => {
      this.GetAllDishes();
    },
      error => (console.log(error)));

  }

  GetAllDishes() {
    this.dishservice.getDishList().subscribe(data => {
      this.DishList = data;
    },
      error => (console.log(error)));

  }
}

