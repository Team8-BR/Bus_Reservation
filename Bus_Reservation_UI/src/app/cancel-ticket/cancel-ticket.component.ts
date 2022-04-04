import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../userservice.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-cancel-ticket',
  templateUrl: './cancel-ticket.component.html',
  styleUrls: ['./cancel-ticket.component.css']
})
export class CancelTicketComponent implements OnInit {

  constructor(private userService: UserserviceService) { }

  ngOnInit() {
  }
  cancelTicketFormMethod(cancelTicketForm: NgForm) {
    const userDetails = cancelTicketForm.form.value;
    this.userService.cancelTicket(userDetails).subscribe((res)=>{
      console.log(res)
    })
  }


}
