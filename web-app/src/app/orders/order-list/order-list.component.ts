import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Order } from '../order-models/order';
import { OrdersService } from '../orders-service/orders.service';
import { OrderDetailComponent } from '../order-detail/order-detail.component';

@Component({
  selector: 'web-app-order-list',
  standalone: true,
  imports: [CommonModule, OrderDetailComponent],
  templateUrl: './order-list.component.html',
  styleUrl: './order-list.component.scss',
})
export class OrderListComponent implements OnInit {
  @Input() companyId = 1;
  orders: Order[] = [];

  get ordersCaption(): string {
    // Default to "Your" if no company name is available (e.g. while loading).
    const possessiveTerm: string = this.orders[0]?.companyName || "Your";
    return `${ possessiveTerm } Orders:`;
  }
  
  constructor(private ordersService: OrdersService) {
  }

  ngOnInit(): void {
    this.ordersService.getOrders(this.companyId).subscribe({
      next: (result: Order[]) => this.orders = result,
      error: () => this.orders = []
    });
  }
}
