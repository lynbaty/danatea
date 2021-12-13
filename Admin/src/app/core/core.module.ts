import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SideBarComponent } from './components/side-bar/side-bar.component';
import { AccountModule } from '../account/account.module';
import { Router, RouterModule } from '@angular/router';
import { NavBarComponent } from './components/nav-bar/nav-bar.component';
import { AuthGuard } from './guards/auth.guard';



@NgModule({
  declarations: [
    SideBarComponent,
    NavBarComponent
  ],
  imports: [
    CommonModule,
    AccountModule,
    RouterModule,
  ],
  exports: [SideBarComponent,
  NavBarComponent]
})
export class CoreModule { }
