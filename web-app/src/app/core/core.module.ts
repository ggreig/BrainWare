import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './zooter/zooter.component';
import { HeaderComponent } from './header/header.component';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    HeaderComponent,
    FooterComponent
  ],
  exports: [HeaderComponent, FooterComponent]
})
export class CoreModule { }
