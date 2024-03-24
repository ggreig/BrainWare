import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OrdersModule } from './orders/orders.module';
import { Title } from '@angular/platform-browser';
import { CoreModule } from './core/core.module';

@Component({
  standalone: true,
  imports: [CommonModule, RouterModule, CoreModule, OrdersModule],
  selector: 'web-app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss',
})
export class AppComponent implements OnInit {
  year = new Date().getFullYear();
  appTitle = "BrainWare";
  pageTitle = "";
  strapLine = "";

  public constructor(private titleService: Title) {}

  ngOnInit() {
    this.pageTitle = `${ this.appTitle} Orders`;
    this.strapLine = `This is the ${ this.appTitle} orders page. Welcome!`;
    this.titleService.setTitle(this.pageTitle);
  }
}
