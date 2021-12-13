import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { IRole } from '../share/models/IRole';

@Injectable({
  providedIn: 'root'
})
export class RoleService {

  baseUrl = environment.baseAPI;
  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
  }

  getRoles(){
    return this.httpClient.get<IRole[]>(this.baseUrl+"role");
  }

  deleteRole(id: string){
    return this.httpClient.delete(this.baseUrl+"role/"+id);
  }
}
