import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatButtonModule, MatCheckboxModule, MatMenuModule, MatStepperModule, MatFormFieldModule, MatInputModule, MatTabsModule, MatCardModule, MatProgressSpinnerModule, MatToolbarModule} from '@angular/material';

import { AppComponent } from './app.component';
import { PaymentDetailsComponent } from './payment-details/payment-details.component';
import { routing } from './app.routing';
import { PaymentResultsComponent } from './payment-results/payment-results.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PaymentsService } from './service/payments-service.service';
import { HttpModule } from '@angular/http';


@NgModule({
  declarations: [
    AppComponent,
    PaymentDetailsComponent,
    PaymentResultsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    BrowserAnimationsModule,
    MatButtonModule, MatCheckboxModule, MatMenuModule, MatStepperModule , MatFormFieldModule,MatInputModule,
    MatTabsModule, MatCardModule, MatProgressSpinnerModule, MatToolbarModule,
        routing
  ],
  providers: [PaymentsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
