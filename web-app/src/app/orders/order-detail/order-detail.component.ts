import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Order } from '../orders-service/order';

@Component({
  selector: 'web-app-order-detail',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './order-detail.component.html',
  styleUrl: './order-detail.component.scss',
})
export class OrderDetailComponent {
  @Input() order: Order = new Order();
}
