import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './account/login/login.component';
import { LogoutComponent } from './account/logout/logout.component';
import { AuthGuard } from './core/guards/auth.guard';
import { HomeComponent } from './home/home.component';
import { CreateComponent } from './role/create/create.component';
import { RoleComponent } from './role/role.component';
import { UserComponent } from './user/user.component';

const routes: Routes = [
  {path:'',component: HomeComponent,canActivate: [AuthGuard]},
  {path:'login',component: LoginComponent},
  {path:'logout',component: LogoutComponent},
  {path:'user', loadChildren: ()=> import('./user/user.module').then(mod => mod.UserModule),canActivate: [AuthGuard]},
  {path:'role', loadChildren: ()=> import('./role/role.module').then(mod => mod.RoleModule),canActivate: [AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
