import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer/Footer.component';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    FooterComponent
  ],
  exports: [FooterComponent]
})
export class CoreModule { }
