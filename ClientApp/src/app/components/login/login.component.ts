import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginCreds } from 'src/app/models/loginCreds';
import { Student } from 'src/app/models/student';
import { Token } from 'src/app/models/token';
import { LoginService } from 'src/app/services/login.service';
import { StudentService } from 'src/app/services/student.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
loginForm:FormGroup;

constructor(private loginService:LoginService,private router:Router){
  this.loginForm=new FormGroup({
    'email':new FormControl('', Validators.required),
    'password':new FormControl('', Validators.required)
  })
}

ngOnInit(){

}
onSubmit(){
  if(this.loginForm.valid){
    let loginCreds=new LoginCreds();
    loginCreds.email=this.loginForm.value["email"];
    loginCreds.password=this.loginForm.value["password"];
    this.loginService.Login(loginCreds).subscribe(
      (data:Token)=>{
        if(data==null){
          alert('Incorrect email or password');
        }
        else{
          localStorage.setItem('token', data.token);
            this.router.navigateByUrl('/');
        }
      }
    )
  }
  else{
    alert("Form input error");
  }
}

}
