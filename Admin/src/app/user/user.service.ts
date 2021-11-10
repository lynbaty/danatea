import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { IUser } from '../share/models/IUser';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  baseUrl = environment.baseAPI;
  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
  }

  getUsers(){
    return this.httpClient.get<IUser[]>(this.baseUrl+"user");
  }

  getUsersbyId(value:string){
    return this.httpClient.get<IUser>(this.baseUrl+"user/"+value);
  }
}
