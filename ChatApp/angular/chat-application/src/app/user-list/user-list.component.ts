import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit {

  userList: any;

  constructor() { 

    this.userList = [
      {
        name: 'Saira C',
        online: true
      },
      {
        name: 'Minion',
        online: false
      }
    ]
  }



  ngOnInit() {
  }

}
