import { Component, OnInit } from '@angular/core';
import {RestaurantService} from 'src/app/services/restaurant.service';
import {FormGroup,FormControl,Validators} from '@angular/forms'
import { ActivatedRoute,Router } from '@angular/router'

@Component({
  selector: 'app-add-edit-res',
  templateUrl: './add-edit-res.component.html',
  styleUrls: ['./add-edit-res.component.css']
})
export class AddEditResComponent implements OnInit {
    
  // restaurantForm=new FormGroup({
  //   RestaurantName : new FormControl(''),
  //   ContactNumber : new FormControl(''),
  //   Location : new FormControl(''),
  //   OpenTime : new FormControl(''),
  //   CloseTime : new FormControl(''),
  //   CostForTwo : new FormControl(''),
  //   Rating : new FormControl(''),
  //   CreatedAt : new FormControl(''),
  //   DeletedAt : new FormControl(''),
  //   CreatedBy : new FormControl(''),
  //   DeletedBy : new FormControl(''),
  // })
  restaurantForm : FormGroup;
  restaurant_update : any;
  restaurant_: any;
  pageTitle: string;
  Id : any;


  constructor(private service :RestaurantService,private route: ActivatedRoute,private router: Router) { }

  ngOnInit(): void {
    
     this.Id = +this.route.snapshot.paramMap.get('id')
   
    
     if(this.Id!=0)
     {
       this.pageTitle = "Update";
        this.service.getRestaurant(this.Id).subscribe(data => {
          this.restaurantForm=new FormGroup ({
            RestaurantName : new FormControl(data['RestaurantName'],Validators.required),
            ContactNumber : new FormControl(data['ContactNumber'],[Validators.required,Validators.minLength(10)]),
            Location : new FormControl(data['Location'],Validators.required),
            OpenTime : new FormControl(data['OpenTime'],Validators.required),
            CloseTime : new FormControl(data['CloseTime'],Validators.required),
            CostForTwo : new FormControl(data['CostForTwo'],[Validators.required,Validators.minLength(5)]),
            Rating : new FormControl(data['Rating'],Validators.required),
            // CreatedAt : new FormControl(data['CreatedAt']),
            // DeletedAt : new FormControl(data['DeletedAt']),
            // CreatedBy : new FormControl(data['CreatedBy']),
            // DeletedBy : new FormControl(data['DeletedBy']),
           })
        })
      
     }
     else {
       this.pageTitle = "Submit";
       this.restaurantForm=new FormGroup({
        RestaurantName : new FormControl('',Validators.required),
        ContactNumber : new FormControl('',[Validators.required,Validators.minLength(10)]),
        Location : new FormControl('',Validators.required),
        OpenTime : new FormControl('',Validators.required),
        CloseTime : new FormControl('',Validators.required),
        CostForTwo : new FormControl('',[Validators.required,Validators.minLength(5)]),
        Rating : new FormControl('',Validators.required),
        // CreatedAt : new FormControl(''),
        // DeletedAt : new FormControl(''),
        // CreatedBy : new FormControl(''),
        // DeletedBy : new FormControl(''),
      })
       
     }

  }

  OnSubmit(){
      alert(JSON.stringify(this.restaurantForm.value));

      console.log(this.Id);
      if ( this.Id == 0) {
        const res = this.restaurantForm.value;
        this.Insert(res);
      }
      else {
      
        const res2 = this.restaurantForm.value;
        this.update(this.Id,res2) ;
      
      }
      this.service.getResList().subscribe();
      this.router.navigate(['./restaurant']);
      
    }

    update(id: any, item: any) {
      this.service.update(id, item).subscribe((data) => {
       console.log(data);
      },error => (console.log(error)));
    }
  
    Insert(resto: any) {
      this.service.create(resto).subscribe(() => {
        
      },error => (console.log(error)));

    }
}