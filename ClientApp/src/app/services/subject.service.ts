import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Subject } from '../models/subject';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class SubjectService {

  constructor(private http:HttpClient) { }
  ProfessorsSubject(id:number):Observable<Array<Subject>>{
    return this.http.get<Array<Subject>>(environment.serviceUrl+'/api/Subject/ProfessorsSubjects/'+id);
  }
}
