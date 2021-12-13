import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AccountService } from '../account.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm : FormGroup;
  constructor(private accountService : AccountService, private fb: FormBuilder, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      email: [''],
      password: [''],
      remember: [false],
    })
  }
  onSubmit(){
    this.accountService.login(this.loginForm.value).subscribe(() => {
      let url = this.route.snapshot.queryParamMap.get('returnUrl') || '/user';
      this.router.navigateByUrl(url);
    },error => console.log(error));
    console.log(this.loginForm.value)
  }







}
