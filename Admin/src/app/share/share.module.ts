import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { ActivatedRoute, RouterLinkWithHref, RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';




@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,

  ],
  exports: [
    ReactiveFormsModule,
    HttpClientModule,

  ]
})
export class ShareModule { }
