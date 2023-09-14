import { Subject } from "./subject";

export class Exam
{
    subject:Subject=new Subject();
    subjectId:number=0;
    date:Date=new Date();
    classRoom:string="";
    examinationPeriod:string="";
}