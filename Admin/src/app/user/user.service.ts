import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { IRole } from '../share/models/IRole';
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

  getRoles(){
    return this.httpClient.get<IRole[]>(this.baseUrl+"role");
  }

  deleteRole(id: string){
    return this.httpClient.delete(this.baseUrl+"role/"+id);
  }
}
