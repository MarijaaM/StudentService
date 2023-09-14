import { Professor } from "./Professor";
import { Exam } from "./exam";

export class Subject{
    name:string="";
    id:number=0;
    professor:Professor=new Professor();
    professorId:number=0;
    //exams:Array<Exam>=new Array<Exam>();
}