import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-payment-results',
  templateUrl: './payment-results.component.html',
  styleUrls: ['./payment-results.component.css']
})
export class PaymentResultsComponent implements OnInit {

  status : string;
  statusMessage: string;
  constructor(private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.activatedRoute.queryParams.subscribe(params => {
      var statusMessage = params["status"];
      this.status = statusMessage;
      this.statusMessage = statusMessage == "success" ? "Transaction successfully intiated!!" : "Error occured. Please try after sometime";
  });
  }

}
