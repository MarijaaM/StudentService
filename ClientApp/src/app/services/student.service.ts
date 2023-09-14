import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 
import { Student } from '../models/student';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';
import { LoginCreds } from '../models/loginCreds';

@Injectable({
  providedIn: 'root'
})
export class StudentService {
  Registration(student:Student):Observable<boolean>{
    return this.http.post<boolean>(environment.serviceUrl+'/api/Student',student);
  
  }
  constructor(private http:HttpClient) { }
}
