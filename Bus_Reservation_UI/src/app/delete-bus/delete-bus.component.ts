import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../userservice.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-delete-bus',
  templateUrl: './delete-bus.component.html',
  styleUrls: ['./delete-bus.component.css']
})
export class DeleteBusComponent implements OnInit {
  buss: any = [];
  constructor(private userService: UserserviceService) { }

  ngOnInit() {
  }
  deleteBusMethod(deleteBus: NgForm) {
    const userDetails = deleteBus.form.value;
    this.userService.deleteBus(userDetails).subscribe((res)=>{
      console.log(res)
    })
  }
}
