import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss'],
})
export class UserListComponent implements OnInit {
  users: any[] = [];

  constructor(private userService: UserService) {}

  ngOnInit() {
    this.userService.getUsers().subscribe(
      data => {
        this.users = data;
        console.dir(data)

      },
      error => {
        console.error('Hubo un error al obtener los datos, no te preocupes, intentalo mas tarde:', error);
        this.users = [];

      }
    );
  }
}