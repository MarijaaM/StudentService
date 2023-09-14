import { StudyProgram } from "./studyProgram";
import { Subject } from "./subject";


export class StudyProgramSubjects{
    id:number=0;
    studyProgramId:number=0;
    subjectId:number=0;
    year:number=0;
    subject:Subject=new Subject();
    studyProgram:StudyProgram=new StudyProgram();
}