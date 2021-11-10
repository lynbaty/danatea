import { Component, Input, OnInit } from '@angular/core';
import { IUser } from 'src/app/share/models/IUser';

@Component({
  selector: 'app-user-items',
  templateUrl: './user-items.component.html',
  styleUrls: ['./user-items.component.scss']
})
export class UserItemsComponent implements OnInit {
  @Input() user : IUser;

  constructor() { }

  ngOnInit(): void {
  }

}
