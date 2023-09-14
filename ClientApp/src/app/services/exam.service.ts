import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Exam } from '../models/exam';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ExamService {

  constructor(private http:HttpClient) { }
  CreateExam(exam:Exam):Observable<boolean>{
    return this.http.post<boolean>(environment.serviceUrl+'/api/Exam/createexam',exam);
  }
  }
    
  
  

