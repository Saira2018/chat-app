import { Component, OnInit } from '@angular/core';
import { Message } from '../shared/models/message';
import { User } from '../shared/models/user';

@Component({
  selector: 'app-chat-content',
  templateUrl: './chat-content.component.html',
  styleUrls: ['./chat-content.component.scss']
})

export class ChatContentComponent implements OnInit {

  userSaira: any;
  userSelf: any; 

  messages: Message [];

  constructor() {

    const userSaira = new User('Saira C');
    const userSelf = new User('You');

     this.messages = [ 
      new Message( userSaira, 'Hey there!'),
      new Message( userSaira, 'How is everybody doing??'),
      new Message( userSaira, 'So glad this chat is up and running!'),
      new Message( userSelf, 'I know, me too'),

    ];
   }

  ngOnInit() {

  }
}
