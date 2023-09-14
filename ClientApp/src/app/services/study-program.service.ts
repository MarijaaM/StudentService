import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StudyProgram } from '../models/studyProgram';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class StudyProgramService {

  constructor(private http:HttpClient) { }
  GetAll():Observable<Array<StudyProgram>>{
    return this.http.get<Array<StudyProgram>>(environment.serviceUrl+'/api/StudyProgram');
  }
}
