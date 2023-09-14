import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { LoginCreds } from '../models/loginCreds';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';
import { Token } from '../models/token';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http:HttpClient) { }
  Login(student:LoginCreds):Observable<Token>{
    return this.http.post<Token>(environment.serviceUrl+'/api/Login',student);
  }
}
