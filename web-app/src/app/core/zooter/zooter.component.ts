import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'web-app-footer',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './zooter.component.html',
  styleUrl: './zooter.component.scss',
})
export class FooterComponent {
  year = new Date().getFullYear();
}
