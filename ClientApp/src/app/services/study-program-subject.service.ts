import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { StudyProgramSubjects } from '../models/studyProgramSubjects';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class StudyProgramSubjectService {

  constructor(private http:HttpClient) { }
  Subjects(studentId:number):Observable<Array<StudyProgramSubjects>>{
    return this.http.get<Array<StudyProgramSubjects>>(environment.serviceUrl+'/api/StudyProgramSubjects/subjects/'+studentId);
}
}
