import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Professor } from 'src/app/models/Professor';
import { Student } from 'src/app/models/student';
import { ProfessorService } from 'src/app/services/professor.service';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent implements OnInit{
registerForm:FormGroup;
constructor(private professorService:ProfessorService, private router:Router){
  this.registerForm=new FormGroup({
    'firstname': new FormControl('', Validators.required),
    'lastname': new FormControl('', Validators.required),
    'email' : new FormControl('', Validators.required),
    'password' : new FormControl('', Validators.required),
    'password2' : new FormControl('', Validators.required),
  })
}
ngOnInit(){

}
onSubmit():void
{
  if(this.registerForm.valid)
    {
      let professor:Professor=new Professor();
      professor.firstname=this.registerForm.value["firstname"];
      professor.lastname=this.registerForm.value["lastname"];
      professor.password=this.registerForm.value["password"];
      professor.email=this.registerForm.value["email"];
     
    if(professor.password!=this.registerForm.value['password2'])
    {
      alert("Passwords do not match");
      return;
    }
    
      this.professorService.Registration(professor).subscribe(
        (data:boolean)=>{
          if(data==false){
            alert("User already exists");
          }
          else{
            this.router.navigateByUrl("/login");
          }
        }

      );
    }
    else{
      alert("Greska u unosu forme");
    }

}
}
