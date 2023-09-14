import { Subject } from "./subject";

export class Professor{
    firstname:string="";
    lastname:string="";
    id:number=0;
    email:string="";
    password:string="";
    subjects:Array<Subject>=new Array<Subject>();
}