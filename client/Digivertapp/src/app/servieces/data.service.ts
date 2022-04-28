import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { User } from '../models/user';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  doSignUp(signUp:any) {
    throw new Error('Method not implemented.');
  }



  constructor(private http: HttpClient) {

  }
  //users
  getAllUsers(): Observable<User[]> {
    return this.http.get<User[]>("http://localhost:4200/api/User/Get")
  }

  loginUser(signUp: User):Observable<User>{
    return this.http.post<User>("http://localhost:4200/api/User/SignUp",signUp)
  }
}
