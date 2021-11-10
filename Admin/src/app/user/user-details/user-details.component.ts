import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IUser } from 'src/app/share/models/IUser';
import { UserService } from '../user.service';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.scss']
})
export class UserDetailsComponent implements OnInit {
  user: IUser;
  id: string
  constructor(private route: ActivatedRoute, private userService: UserService) { }

  ngOnInit(): void {
   this.route.params.subscribe(param => this.id = param['id']);
   console.log(this.id);
   this.userService.getUsersbyId(this.id).subscribe((response:IUser) => this.user=response,error => console.log(error));
  }
}
