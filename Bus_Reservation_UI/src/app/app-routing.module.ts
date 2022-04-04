import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { BookTicketComponent } from './book-ticket/book-ticket.component';
import { AddBusComponent } from './add-bus/add-bus.component';
import { UpdateBusComponent } from './update-bus/update-bus.component';
import { DeleteBusComponent } from './delete-bus/delete-bus.component';
import { ShowAllBusesComponent } from './show-all-buses/show-all-buses.component';
import { CheckAvaliabilityComponent } from './check-avaliability/check-avaliability.component';
import { CancelTicketComponent } from './cancel-ticket/cancel-ticket.component';
import { ViewTicketComponent } from './view-ticket/view-ticket.component';
import { UpdateUserComponent } from './update-user/update-user.component';
import { PaymentComponent } from './payment/payment.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path:'register',component:RegisterComponent},
  {path:'login',component:LoginComponent},
   {path: 'addBus', component: AddBusComponent},
   {path: 'updateBus', component: UpdateBusComponent},
   {path: 'deleteBus', component: DeleteBusComponent},
  {path: 'showAllBuses', component: ShowAllBusesComponent},
  {path: 'bookTicket', component: BookTicketComponent},
  {path: 'viewTicket', component: ViewTicketComponent},
   {path: 'checkAvaliability', component: CheckAvaliabilityComponent},
  {path: 'updateUser', component: UpdateUserComponent},
  {path: 'cancelTicket', component: CancelTicketComponent},
  {path: 'makepayment', component: PaymentComponent}
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

