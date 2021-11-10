import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders} from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BehaviorSubject } from 'rxjs';
import { ILogin} from '../share/models/ILogin';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  baseUrl = environment.baseAPI;
  private userSource = new BehaviorSubject<ILogin>(null);
  user$ = this.userSource.asObservable();
  constructor(private httpClient : HttpClient) { }

  login(value: any){
    return this.httpClient.post<ILogin>(this.baseUrl+"login",value).pipe(
      map((user:ILogin) => {
        if(user) localStorage.setItem('Token',user.token);
        this.userSource.next(user);
      })
    );
  }
  logout(){
      localStorage.removeItem('Token');
      this.userSource.next(null);
  }
  currentLogin(){
    return this.userSource.value;
  }
  getUser(header: HttpHeaders){
    return this.httpClient.get<ILogin>(this.baseUrl+"login",{headers: header}).pipe(
      map((user:ILogin) => {
        this.userSource.next(user);
      }));
  }
}
