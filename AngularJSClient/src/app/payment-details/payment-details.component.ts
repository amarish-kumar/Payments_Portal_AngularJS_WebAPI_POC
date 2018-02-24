import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PaymentInterface } from '../payment-interface';
import { PaymentsService } from '../service/payments-service.service';
import { _catch } from 'rxjs/operator/catch';
import { error } from 'util';
import { NavigationExtras } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-payment-details',
  templateUrl: './payment-details.component.html',
  styleUrls: ['./payment-details.component.css']
})

export class PaymentDetailsComponent implements OnInit {
  formGroup: FormGroup;
  paymentInt: PaymentInterface;
  submitted: boolean = false;

  constructor(private fb: FormBuilder, private paymentSvc: PaymentsService, private router: Router) { }

  ngOnInit() {
    // Initialize form group with validations.
    this.formGroup = this.fb.group({
      bsb: ['', [Validators.required, Validators.maxLength(6)]],
      confirmaccountnumber: ['', [Validators.required, Validators.maxLength(11)]],
      accountnumber: ['', [Validators.required, Validators.maxLength(11)]],
      accountname: ['', [Validators.required]],
      currency: ['', [Validators.required]],
      amount: ['', Validators.required],
      reference: ''
    });
  }

  save(model: PaymentInterface, isValid: boolean) {
    this.submitted = true;

    if (!isValid) {
      return;
    }

    this.paymentSvc.savePaymentDetails(model)
    .subscribe(result => {
      let navigationExtras: NavigationExtras = {        
        queryParams: {
            "status": "success"
        }        
    };

    this.router.navigate(['result'], navigationExtras);
    },
    error =>{
      let navigationExtras: NavigationExtras = {        
        queryParams: {
            "status": "failure"
        }        
    };
    
    this.router.navigate(['result'], navigationExtras);
    });
  }
}
