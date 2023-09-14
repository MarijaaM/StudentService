import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import {  Router } from '@angular/router';
import { Student } from 'src/app/models/student';
import { StudyProgram } from 'src/app/models/studyProgram';
import { StudentService } from 'src/app/services/student.service';
import { StudyProgramService } from 'src/app/services/study-program.service';

@Component({
  selector: 'app-register-student',
  templateUrl: './register-student.component.html',
  styleUrls: ['./register-student.component.css']
})
export class RegisterStudentComponent {
  studyPrograms:Array<StudyProgram>=new Array<StudyProgram>();
  registerStudent:FormGroup;
  constructor(private studyProgramService:StudyProgramService,private studentService:StudentService,private router:Router){
    this.registerStudent=new FormGroup({
      'firstname': new FormControl('', Validators.required),
      'lastname': new FormControl('', Validators.required),
      'email' : new FormControl('', Validators.required),
      'indexNumber' : new FormControl('', Validators.required),
      'password' : new FormControl('', Validators.required),
      'methodOfFinancing' : new FormControl('', Validators.required),
      'yearOfStudy' : new FormControl('', Validators.required),
      'studyProgram' : new FormControl('', Validators.required)
    })
    studyProgramService.GetAll().subscribe(
      (data)=>{
        this.studyPrograms=data;
      }

    )
  }
  onSubmit():void{
    if(this.registerStudent.valid)
    {
    let student=new Student();
    student.firstname=this.registerStudent.value["firstname"];
    student.lastname=this.registerStudent.value["lastname"];
    student.email=this.registerStudent.value["email"];
    student.indexNumber=this.registerStudent.value["indexNumber"];
    student.password=this.registerStudent.value["password"];
    student.methodOfFinancing=this.registerStudent.value["methodOfFinancing"];
    student.yearOfStudy=this.registerStudent.value["yearOfStudy"];
    student.studyProgramId=this.registerStudent.value["studyProgram"];

    this.studentService.Registration(student).subscribe(
      (data)=>{
        if(data==false){
          alert("User already exists");
        }
        else{
          this.router.navigateByUrl("");
        }
      }

    );
  }
  else{
    alert("Greska u unosu forme");
  }
 }
}
    
  

