import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CreateComponent } from './create/create.component';
import { RoleComponent } from './role.component';
import { ShareModule } from '../share/share.module';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from '../app-routing.module';
import { RoleItemsComponent } from './role-items/role-items.component';
import { RouterModule } from '@angular/router';
import { RoleRoutingModule } from './role-routing.module';



@NgModule({
  declarations: [
    RoleComponent,
    CreateComponent,
    RoleItemsComponent
  ],
  imports: [
    CommonModule,
    ShareModule,
    RoleRoutingModule,
    BrowserModule
  ],
  exports: [
    RoleComponent,
    RouterModule
  ]

})
export class RoleModule { }
