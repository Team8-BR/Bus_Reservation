import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserserviceService {
 userUrl = 'http://localhost:1902/api/Customer/InsertData';
 addBusUrl='http://localhost:1902/api/BusDetails';
 updateBusUrl='http://localhost:1902/api/BusSchedule/InsertData';
 deleteBusUrl='http://localhost:1902/api/BusDetails';
 showallBusUrl='http://localhost:1902/api/BusSchedule/allDetails';
 setAvalibilityUrl='http://localhost:1902/api/BusSchedule/allDetails';
 bookTicketUrl='http://localhost:1902/api/Ticket Booking/InsertData';
 cancelTicketUrl='http://localhost:1902/api/TicketCancellation';
 viewTickersUrl='http://localhost:1902/api/TicketBooking';
 paymentUrl='http://localhost:1902/api/Payments/InsertData';
 constructor(private http: HttpClient) { }
 
 register(data: any) {
   console.log(data);
   return this.http.post<any>(`${this.userUrl}`, data);
 }
 addBus(data: any) {
  return this.http.post<any>(`${this.addBusUrl}/InsertData`, data);
 }
 updateBus(data: any) {
  return this.http.put(`${this.updateBusUrl}`, data);
}
deleteBus(data: any) {
  return this.http.delete(`${this.deleteBusUrl}/${data}`);
}
showAllBus() {
  return this.http.get<any>(`${this.showallBusUrl}`);
}
 setAvaliability(data: any) {
  console.log(data);
  return this.http.post(`${this.setAvalibilityUrl}/`, data);
}
bookTicket(data: any) {
  return this.http.post<any>(`${this.bookTicketUrl}`, data);
}
cancelTicket(data: { bookingId: any; }) {
  return this.http.delete<any>(`${this.cancelTicketUrl}/${data.bookingId}`);
}
viewTicket(data: { bookingId: any; }) {
  return this.http.get<any>(`${this.viewTickersUrl}/${data.bookingId}`);
}
makePayment(data: any) {
  return this.http.post(`${this.paymentUrl}`, data);
}
}