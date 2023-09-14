import { Exam } from "./exam";

export class Student
{
    id:number=0;
    firstname:string="";
    lastname:string="";
    password:string="";
    indexNumber:string="";
    passedExams:Array<Exam>=new Array<Exam>();
    failedExams:Array<Exam>=new Array<Exam>();
    registeredExams:Array<Exam>=new Array<Exam>();
    methodOfFinancing:number=0;
    email:string="";
    yearOfStudy:number=0;
    studyProgramId:number=0;
}