import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'web-app-footer',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './Footer.component.html',
  styleUrl: './Footer.component.scss',
})
export class FooterComponent {
  year = new Date().getFullYear();
}
