import { TestBed, inject } from '@angular/core/testing';

import { PaymentsService } from './payments-service.service';

describe('PaymentsService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PaymentsService]
    });
  });

  it('should be created', inject([PaymentsService], (service: PaymentsService) => {
    expect(service).toBeTruthy();
  }));
});
