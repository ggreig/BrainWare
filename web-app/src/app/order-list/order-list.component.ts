import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Order } from '../orders-service/order';
import { OrdersService } from '../orders-service/orders.service';
import { OrderDetailComponent } from '../order-detail/order-detail.component';

@Component({
  selector: 'web-app-order-list',
  standalone: true,
  imports: [CommonModule, OrderDetailComponent],
  templateUrl: './order-list.component.html',
  styleUrl: './order-list.component.scss',
})
export class OrderListComponent {
  orders: Order[] = [];

  get companyName(): string {
    // Default to "Your" if no company name is available.
    return this.orders[0]?.companyName || "Your";
  }
  
  constructor(private ordersService: OrdersService) {
    this.ordersService.getOrders().subscribe(orders => this.orders = orders);
  }
}
