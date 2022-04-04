import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UserserviceService } from '../userservice.service';

@Component({
  selector: 'app-check-avaliability',
  templateUrl: './check-avaliability.component.html',
  styleUrls: ['./check-avaliability.component.css']
})
export class CheckAvaliabilityComponent implements OnInit {
  avails: any[] = [];
  check: any = null;
  
  constructor(private userService: UserserviceService) { }

  ngOnInit() {
  }
  checkAvail(checkAvailForm : any) {
    const userDetails = checkAvailForm.form.value;
    this.userService.setAvaliability(userDetails).subscribe((res)=>{
      console.log(res)
    })
  }
}
