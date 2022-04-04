import { Component, OnInit } from '@angular/core';
import { UserserviceService } from '../userservice.service';

@Component({
  selector: 'app-show-all-buses',
  templateUrl: './show-all-buses.component.html',
  styleUrls: ['./show-all-buses.component.css']
})
export class ShowAllBusesComponent implements OnInit {
  buses: any[] = [];
  constructor(private userService: UserserviceService) {this.getBuses(); }

  ngOnInit() {
  }

  getBuses() {
    this.userService.showAllBus().subscribe(data => {
      console.log(data);
      this.buses = data.busList;
    });
  }
}
