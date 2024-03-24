import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from '../order-models/order';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {
  // TODO: Parameterise the ID.    
  public readonly url = '/api/order/1';

  constructor(private http: HttpClient) {
  }

  public getOrders(): Observable<Order[]> {
    return this.http.get<Order[]>(this.url);
  }
}
