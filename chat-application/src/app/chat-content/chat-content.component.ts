import { Component, OnInit } from '@angular/core';
import { Message } from '../shared/models/message';
import { User } from '../shared/models/user';
import { MessageService } from '../core/message.service';

@Component({
  selector: 'app-chat-content',
  templateUrl: './chat-content.component.html',
  styleUrls: ['./chat-content.component.scss']
})

export class ChatContentComponent implements OnInit {

  mockData: Message [];

 // mockData = MOCKMESSAGES;

  // userSaira: any;
  // userSelf: any; 

  // messages: Message [];



  constructor(private _messageService: MessageService) {}

  getMessages(): void {
    // this.mockData = this._messageService.getMessages();
    this._messageService.getMessages()
      .subscribe(mockData => this.mockData = mockData);
      
    
  }
    // const userSaira = new User('Saira C');
    // const userSelf = new User('You');

    //  this.messages = [ 
    //   new Message( userSaira, 'Hey there!'),
    //   new Message( userSaira, 'How is everybody doing??'),
    //   new Message( userSaira, 'So glad this chat is up and running!'),
    //   new Message( userSelf, 'I know, me too'),

    // ];

  ngOnInit() {
    this.getMessages();
  }
}
