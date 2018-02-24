import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs';
import 'rxjs/add/operator/map'
import { PaymentInterface } from '../payment-interface';

@Injectable()
export class PaymentsService {

  constructor(private http: Http) { }

  savePaymentDetails(payment: PaymentInterface){
    let head = new Headers({ 'Content-Type': 'application/json' });
    let requestOptions = new RequestOptions({headers: head});
    return this.http.post('http://localhost:59849/api/Payments', JSON.stringify(payment), requestOptions)
            .map((response: Response) => {              
                return response.json() == "Success";
            })
            .catch((error:any) => Observable.throw(error.json().error || 'Server error'));;
  }

}
