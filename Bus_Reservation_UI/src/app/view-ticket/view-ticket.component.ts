import { Component, OnInit } from '@angular/core';
import { UserserviceService} from '../userservice.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-view-ticket',
  templateUrl: './view-ticket.component.html',
  styleUrls: ['./view-ticket.component.css']
})
export class ViewTicketComponent implements OnInit {
  tickets: any= null;
  show: any = false;
  constructor(private userService: UserserviceService) { }

  ngOnInit() {
  }
  viewTicketFormMethod(viewTicketForm: NgForm) {
    const userDetails = viewTicketForm.form.value;
    this.userService.viewTicket(userDetails).subscribe((res)=>{
      console.log(res)
    })
  }

}
