import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../userservice.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-update-bus',
  templateUrl: './update-bus.component.html',
  styleUrls: ['./update-bus.component.css']
})
export class UpdateBusComponent implements OnInit {
  buss: any = [];
  constructor(private usrService: UserserviceService) { }

  ngOnInit() {
  }
  updateBusInfo(updateBus: NgForm) {
    const userDetails = updateBus.form.value;
    this.usrService.updateBus(userDetails).subscribe((res)=>{
      console.log(res)
    })
  }

}
