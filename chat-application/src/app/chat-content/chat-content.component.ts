import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chat-content',
  templateUrl: './chat-content.component.html',
  styleUrls: ['./chat-content.component.scss']
})

export class ChatContentComponent implements OnInit {

  userSaira: any;
  userSelf: any; 

  constructor() {

    this.userSaira = [{
        name: 'Saira C',
         messages: [
          { text: 'Hey there!'},
          { text: 'How is everybody doing??'},
          { text: 'So glad this chat is up and running!'}
        ]
      }];

    this.userSelf = [{
      name: 'You',
      messages: [
        { text: 'I know, me too' },
        { text: 'This is a lot of fun' }
      ]
    }];

   }

  ngOnInit() {

  }
}
