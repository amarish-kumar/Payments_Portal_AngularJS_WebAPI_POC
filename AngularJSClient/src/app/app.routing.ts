import { Routes, RouterModule } from '@angular/router';
import { PaymentDetailsComponent } from '../app/payment-details/payment-details.component';
import { PaymentResultsComponent } from '../app/payment-results/payment-results.component';

const appRoutes: Routes = [
    { path: '', component: PaymentDetailsComponent },
    {path: 'result', component: PaymentResultsComponent},

    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);