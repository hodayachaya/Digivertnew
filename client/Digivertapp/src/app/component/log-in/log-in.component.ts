import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { DataService } from 'src/app/servieces/data.service';
@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {
  loginForm: FormGroup = new FormGroup({});

  constructor() { }

  ngOnInit(): void {

    this.loginForm = new FormGroup(
      {
      userName: new FormControl('', Validators.required),
      password: new FormControl('', Validators.required),


    }
    )
  }
  checkUser() { }
}


