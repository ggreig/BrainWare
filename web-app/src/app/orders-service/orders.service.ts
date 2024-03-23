import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Order } from './order';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {

  constructor(private http: HttpClient) {
  }
    
  public getOrders(): Observable<Order[]> {
    return this.http.get<Order[]>('/api/order/1');
  }
}
