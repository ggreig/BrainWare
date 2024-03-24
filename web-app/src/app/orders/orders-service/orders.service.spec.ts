import { TestBed } from '@angular/core/testing';
import { OrdersService } from './orders.service';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { Order } from '../order-models/order';
import { fail } from 'assert';

describe('OrdersService', () => {
  let service: OrdersService;
  let httpTestingController: HttpTestingController;

  const mockCompanyId = 0;
  const mockOrder: Order[] = [
    { orderId: 1, companyName: "Test Company", description: "Test Order", orderTotal: 10, orderProducts: [] }
  ];

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [OrdersService]
    });

    httpTestingController = TestBed.inject(HttpTestingController);
    service = TestBed.inject(OrdersService);
  });

  afterEach(() => {
    // After every test, assert that there are no more pending requests
    httpTestingController.verify();
  })

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should GET from expected URL', () => {

    // Act
    service.getOrders(mockCompanyId).subscribe({
      // Confirm that the expected mock response has been received.
      next: (result: Order[]) => expect(result).toBe(mockOrder),
      error: () => fail("because a valid result is expected")
    })

    // Confirm that the service has made a single GET request to the expected URL.
    const request = httpTestingController.expectOne(service.url + mockCompanyId);
    expect(request.request.method).toBe('GET');

    // Provide the request with a mock response.
    request.flush(mockOrder);
  })

  it('should return an empty result on 404', () => {
    service.getOrders(0).subscribe({
      // Confirm that an empty array has been received.
      next: (result: Order[]) => expect(result.length).toBe(0),
      error: () => fail("because a valid empty result is expected")
    });

    // Confirm that the service has made a single GET request to the expected URL.
    const request = httpTestingController.expectOne(service.url + mockCompanyId);

    // Return a 404 to check how it's handled.
    request.flush("Nothing found", { status: 404, statusText: "Not Found"});
  })
});
