import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ILogin } from 'src/app/share/models/ILogin';
import { AccountService } from '../account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm : FormGroup;
  constructor(private accountService : AccountService, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      email: [''],
      password: [''],
      remember: [''],
    })
  }
  onSubmit(){
    this.accountService.login(this.loginForm.value).subscribe(() => console.log("okie"),error => console.log(error));
    console.log(this.loginForm.value)
  }







}
