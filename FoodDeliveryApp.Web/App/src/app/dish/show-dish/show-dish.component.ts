import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import {DishService} from 'src/app/services/dish.service';

@Component({
  selector: 'app-show-dish',
  templateUrl: './show-dish.component.html',
  styleUrls: ['./show-dish.component.css']
})
export class ShowDishComponent implements OnInit {

  constructor(private dishService: DishService, private router:Router) { }
  DishList: any = [];
  ModalTitle: string;
  dish: any;

  ngOnInit(): void {
    this.GetAllDishes();
  }

  deleteClick(item) {
    if (confirm('Are you sure you want to delete this dish?')) {
      this.dishService.delete(item.Id).subscribe(data => {
        //alert(data.toString());
        this.GetAllDishes();
        this.router.navigate(['./dish']);
      },
        error => (console.log(error)))
    }
  }

  GetAllDishes() {
    this.dishService.getDishList().subscribe(data => {
      this.DishList=data;
    },
      error => (console.log(error)));

  }

}
