import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'web-app-order-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './order-list.component.html',
  styleUrl: './order-list.component.scss',
})
export class OrderListComponent {
  orders: any[] = [];
  
  constructor(http: HttpClient) {
    http.get<any>('/api/order/1').subscribe((orders) => {
      this.orders = orders;
    });
  }

}
