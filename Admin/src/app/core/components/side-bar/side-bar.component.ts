import { HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { AccountService } from 'src/app/account/account.service';
import { ILogin } from 'src/app/share/models/ILogin';

@Component({
  selector: 'app-side-bar',
  templateUrl: './side-bar.component.html',
  styleUrls: ['./side-bar.component.scss']
})
export class SideBarComponent implements OnInit {

  user$: Observable<ILogin>;
  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
    this.user$ = this.accountService.user$;
    this.checkUser();
  }

  logout(){
    this.accountService.logout();
  }
  checkUser(){
    var token = localStorage.getItem('Token');
    if(token != null)
    {
      var header = new HttpHeaders();
      header = header.append("Authorization","Bearer "+ token);
      this.accountService.getUser(header).subscribe();
    }

  }
}
