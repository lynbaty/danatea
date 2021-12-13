import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { RoleComponent } from './role.component';
import { CreateComponent } from './create/create.component';

const routes: Routes = [
  {path:'',component: RoleComponent},
  {path:'create',component: CreateComponent},
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]

})
export class RoleRoutingModule { }
