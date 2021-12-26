import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import {RestaurantService} from 'src/app/services/restaurant.service';
import { ActivatedRoute,Router } from '@angular/router'


@Component({
  selector: 'app-show-res',
  templateUrl: './show-res.component.html',
  styleUrls: ['./show-res.component.css']
})
export class ShowResComponent implements OnInit {

  constructor(private service :RestaurantService,private router: Router ) { }
  RestaurantList:any=[];

  ngOnInit(): void {
    this.refreshResList();
  }
  refreshResList(){
    this.service.getResList().subscribe(data => {
      this.RestaurantList=data;
    },error => (console.log(error)));
  }

  deleteClick(item)
  {
    if(confirm('Are you sure??')){
      this.service.delete(item.Id).subscribe(data =>{
        //alert(data.toString());
        this.refreshResList();
        this.router.navigate(['./restaurant']);
      },
      error => (console.log(error)) )
      
    }
  }
 
}
