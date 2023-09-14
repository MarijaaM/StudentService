import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Professor } from '../models/Professor';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProfessorService {

  constructor(private http:HttpClient) { }
  Registration(professor:Professor):Observable<boolean>{
    return this.http.post<boolean>(environment.serviceUrl+'/api/Professor',professor);
}
}
