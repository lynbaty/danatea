import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { LogoutComponent } from './logout/logout.component';
import { ShareModule } from '../share/share.module';
import { AccountService } from './account.service';



@NgModule({
  declarations: [
    LoginComponent,
    LogoutComponent
  ],
  imports: [
    CommonModule,
    ShareModule
  ],
  exports: [
    LoginComponent,
    LogoutComponent
  ]
})
export class AccountModule { }
