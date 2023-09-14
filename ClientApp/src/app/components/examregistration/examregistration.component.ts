import { Component } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { StudyProgramSubjects } from 'src/app/models/studyProgramSubjects';
import { StudyProgramSubjectService } from 'src/app/services/study-program-subject.service';

@Component({
  selector: 'app-examregistration',
  templateUrl: './examregistration.component.html',
  styleUrls: ['./examregistration.component.css']
})
export class ExamregistrationComponent {
subjects:Array<StudyProgramSubjects>=new Array<StudyProgramSubjects>();

constructor(private studyProgramSubjectsService:StudyProgramSubjectService,private helper: JwtHelperService){
  let token = localStorage.getItem("token");
    //  if (token != null) {
       // let token1 = this.helper.decodeToken(token);
  studyProgramSubjectsService.Subjects(1).subscribe(
    (data)=>{
      this.subjects=data;
    }
  )
      }
//}
}
