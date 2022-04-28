import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/models/user';
import { DataService } from 'src/app/servieces/data.service';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {


  users: User[] = [];

  constructor(private db: DataService) { }

  ngOnInit(): void {
  }

  getAllUsers() {
    this.db.getAllUsers().subscribe((users) => {
      console.log(users);
      this.users = users;
    })
  }
}
