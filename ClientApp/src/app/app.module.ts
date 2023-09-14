import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule  }   from '@angular/forms'

import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegistrationComponent } from './components/registration/registration.component';
import { StudentService } from './services/student.service';
import { LoginComponent } from './components/login/login.component';
import { ExamregistrationComponent } from './components/examregistration/examregistration.component';
import { JwtModule } from "@auth0/angular-jwt";
import { environment } from './environments/environment';
import { RegisterStudentComponent } from './components/register-student/register-student.component';
import { CreateExamComponent } from './components/create-exam/create-exam.component';
export function tokenGetter() {
  return localStorage.getItem("token");
}
@NgModule({
  declarations: [
    AppComponent,
    RegistrationComponent,
    LoginComponent,
    ExamregistrationComponent,
    RegisterStudentComponent,
    CreateExamComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
     JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: environment.allowedDomains
      }
    })
    
  ],
  providers: [
    StudentService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
