import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Exam } from 'src/app/models/exam';
import { Subject } from 'src/app/models/subject';
import { ExamService } from 'src/app/services/exam.service';
import { SubjectService } from 'src/app/services/subject.service';

@Component({
  selector: 'app-create-exam',
  templateUrl: './create-exam.component.html',
  styleUrls: ['./create-exam.component.css']
})
export class CreateExamComponent {
createExamForm:FormGroup;
subjects:Array<Subject>=new Array<Subject>();
constructor(private examService:ExamService,private subjectService:SubjectService,private helper:JwtHelperService){
  let token = localStorage.getItem("token");
  if (token != null) {
    let token1 = helper.decodeToken(token);
    subjectService.ProfessorsSubject(token1.id).subscribe(
      (data)=>{
        this.subjects=data;
      }
     )
  }
  this.createExamForm=new FormGroup({
    'subject': new FormControl('', Validators.required),
    'classRoom': new FormControl('', Validators.required),
    'date' : new FormControl('', Validators.required),
    'examinationPeriod' : new FormControl('', Validators.required)
  });
 
}
onSubmit():void{
  let exam=new Exam();
  exam.subjectId=this.createExamForm.value["subject"];
  exam.classRoom=this.createExamForm.value["classRoom"];
  exam.date=this.createExamForm.value["date"];
  exam.examinationPeriod=this.createExamForm.value["examinationPeriod"];
  
  this.examService.CreateExam(exam).subscribe(
    (data)=>{
      if(data){
        alert("Successfuly added new exam");
      }
      else{
        alert("Something went wrong");;
      }
    }
    
  )

}
}
