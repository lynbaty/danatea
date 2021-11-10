import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SideBarComponent } from './components/side-bar/side-bar.component';
import { AccountModule } from '../account/account.module';
import { Router, RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    SideBarComponent
  ],
  imports: [
    CommonModule,
    AccountModule,
    RouterModule
  ],
  exports: [SideBarComponent]
})
export class CoreModule { }
