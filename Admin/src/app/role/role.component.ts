import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { IRole } from '../share/models/IRole';
import { RoleService } from './role.service';

@Component({
  selector: 'app-role',
  templateUrl: './role.component.html',
  styleUrls: ['./role.component.scss']
})
export class RoleComponent implements OnInit {

  roles: IRole[]
  constructor(private roleService: RoleService, private router: Router) { }

  ngOnInit(): void {
    this.roleService.getRoles().subscribe((response: IRole[]) => {
      this.roles = response;
      console.log(this.roles);
    },error => console.log(error));
  }

  delete(id: string){
    this.roleService.deleteRole(id).subscribe(error => console.log(error));
  }
  redirect(){
    this.router.navigate(['user/create']);
  }
}
