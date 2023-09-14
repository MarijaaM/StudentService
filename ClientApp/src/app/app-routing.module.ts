import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegistrationComponent } from './components/registration/registration.component';
import { LoginComponent } from './components/login/login.component';
import { ExamregistrationComponent } from './components/examregistration/examregistration.component';
import { CreateExamComponent } from './components/create-exam/create-exam.component';
import { RegisterStudentComponent } from './components/register-student/register-student.component';

const routes: Routes = [
  {
    path: "registration",
    component: RegistrationComponent
  },
  {
    path: "registerstudent",
    component: RegisterStudentComponent
  },
  {
    path: "login",
    component: LoginComponent
  },
  {
    path:"examregistration",
    component:ExamregistrationComponent
  },
  {
    path:"createexam",
    component:CreateExamComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
