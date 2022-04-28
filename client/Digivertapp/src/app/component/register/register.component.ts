import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, FormsModule, Validators } from '@angular/forms';
import { register } from "src/app/models/register.1";


import { DataService } from 'src/app/servieces/data.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  registeruserForm: FormGroup=new FormGroup({});

  constructor(private data: DataService) { }

  ngOnInit(): void {
    this.registeruserForm = new FormGroup(
      {

        id:new FormControl('', Validators.required),
        name: new FormControl('', Validators.required),
        pass: new FormControl('', Validators.required),
        FirstName: new FormControl('', Validators.required),
        LastName: new FormControl('', Validators.required),
        Phon: new FormControl('', Validators.required),
        email: new FormControl('', Validators.required),

      }
    )
  }
  doSignUp() {
    console.log(this.registeruserForm);
    const register:register = {
      userName: this.registeruserForm.controls['name'].value,
      password: this.registeruserForm.controls['pass'].value,
      FirstName: this.registeruserForm.controls['FirstName'].value,
      LastName: this.registeruserForm.controls['LastName'].value,
      Phon: this.registeruserForm.controls['Phon'].value,
      email: this.registeruserForm.controls['email'].value,
      idUser: this.registeruserForm.controls['id'].value,
     
    }

    // console.log(signUp);
    // this.data.doSignUp(signUp).subscribe(res  => {
    //   console.log(res)

    //   if (res == null)
    //     alert("שגיאת שרת")
    //   else
    //     alert("כניסה למערכת")
    // })
  }

}


