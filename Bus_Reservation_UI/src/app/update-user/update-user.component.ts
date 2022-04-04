import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserserviceService} from '../userservice.service';

@Component({
  selector: 'app-update-user',
  templateUrl: './update-user.component.html',
  styleUrls: ['./update-user.component.css']
})
export class UpdateUserComponent implements OnInit {
  userr: any = [];
  constructor(private userService: UserserviceService) { }

  ngOnInit() {
  }
  user(updateUser: NgForm) {
  

  }
}
