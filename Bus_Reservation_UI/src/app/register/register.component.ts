import { Component, OnInit } from '@angular/core';
// import { UserServiceService } from '../user-service.service';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { UserserviceService } from '../userservice.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  name = 'enjoyer';
  constructor(private router: Router, private userService: UserserviceService) { }

  ngOnInit() {
  }
  user(registerUser: NgForm) {
    const userDetails = registerUser.form.value;
    this.userService.register(userDetails).subscribe((res)=>{
      console.log(res)
    })
     this.router.navigateByUrl('/login')
  }

}
