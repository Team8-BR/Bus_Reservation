import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './footer/footer.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
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





@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    FooterComponent,
    RegisterComponent,
    LoginComponent,
    BookTicketComponent,
    UpdateBusComponent,
    DeleteBusComponent,
    AddBusComponent,
    ShowAllBusesComponent,
    CheckAvaliabilityComponent,
    CancelTicketComponent,
    ViewTicketComponent,
    UpdateUserComponent,
    PaymentComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
