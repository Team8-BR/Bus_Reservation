import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginServiceService } from '../login-service.service';
import { UserserviceService } from '../userservice.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private router: Router, private loginService: LoginServiceService, private userService: UserserviceService) { }

  ngOnInit() {
  }
  get isAdminLogin() {
    return this.loginService.isAdminLogin();
  }
  get isCustomerLogin() {
    return this.loginService.isCustomerLogin();
  }
  get getavalia() {
    return

  }
  logout() {
    this.loginService.isAdminLoggedIn = false;
    this.loginService.isCustomerLoggedIn = false;
    this.router.navigateByUrl('/');
  }
  register(){
    this.router.navigateByUrl("/register")
  }
  login(){
    this.router.navigateByUrl("/login")
  }

}

