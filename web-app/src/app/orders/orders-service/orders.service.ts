import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from '../order-models/order';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrdersService { 
  public readonly url = '/api/order/';

  constructor(private http: HttpClient) {
  }

  public getOrders(companyId: number): Observable<Order[]> {
    return this.http.get<Order[]>(this.url + companyId.toString());
  }
}
