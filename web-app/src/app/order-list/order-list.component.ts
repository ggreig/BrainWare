import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Order } from '../orders-service/order';
import { OrdersService } from '../orders-service/orders.service';

@Component({
  selector: 'web-app-order-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './order-list.component.html',
  styleUrl: './order-list.component.scss',
})
export class OrderListComponent {
  orders: Order[] = [];
  
  constructor(private ordersService: OrdersService) {
    this.ordersService.getOrders().subscribe(orders => this.orders = orders);
  }
}
