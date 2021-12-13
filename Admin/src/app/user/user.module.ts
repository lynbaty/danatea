import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserComponent } from './user.component';
import { UserDetailsComponent } from './user-details/user-details.component';
import { UserItemsComponent } from './user-items/user-items.component';
import { RouterModule } from '@angular/router';
import { UserRoutingModule } from './user-routing.module';
import { ShareModule } from '../share/share.module';




@NgModule({
  declarations: [
    UserComponent,
    UserDetailsComponent,
    UserItemsComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule,
    ShareModule

  ],
  exports:[
    UserComponent,
    RouterModule
  ]
})
export class UserModule { }
