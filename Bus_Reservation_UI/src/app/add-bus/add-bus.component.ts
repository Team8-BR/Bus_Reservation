import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserserviceService } from '../userservice.service';

@Component({
  selector: 'app-add-bus',
  templateUrl: './add-bus.component.html',
  styleUrls: ['./add-bus.component.css']
})
export class AddBusComponent implements OnInit {
  createBus: any;

  constructor(private usrService: UserserviceService) { }

  ngOnInit() {
  }
  addBus(createBus: NgForm) {
    const userDetails = createBus.form.value;
    this.usrService.addBus(userDetails).subscribe((res: any)=>{
      console.log(res)
  });
}
}