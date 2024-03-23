import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OrderListComponent } from './order-list/order-list.component';
import { Title } from '@angular/platform-browser';

@Component({
  standalone: true,
  imports: [CommonModule, RouterModule, OrderListComponent],
  selector: 'web-app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent implements OnInit {
  year = new Date().getFullYear();
  appTitle = "BrainWare";
  pageTitle = "";

  public constructor(private titleService: Title) {}

  ngOnInit() {
    this.pageTitle = this.appTitle + " Orders";  
    this.titleService.setTitle(this.pageTitle);
  }
}
