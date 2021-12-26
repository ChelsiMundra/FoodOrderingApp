import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'
import {RestaurantService} from 'src/app/services/restaurant.service';

@Component({
  selector: 'app-single-res',
  templateUrl: './single-res.component.html',
  styleUrls: ['./single-res.component.css']
})
export class SingleResComponent implements OnInit {
  pageTitle = "Restaurant Detail";
  restaurant : any;

  constructor(private service :RestaurantService,private route: ActivatedRoute ) { }

  ngOnInit(): void {
    const id = +this.route.snapshot.paramMap.get('id')
    this.getSingleRestaurant(id)

  }
  
  getSingleRestaurant(id: any)
  {
    this.service.getRestaurant(id).subscribe(data => {
      this.restaurant=data;
    });
  }




}
