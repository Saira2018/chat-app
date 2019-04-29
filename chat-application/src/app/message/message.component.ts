import { Component, OnInit } from '@angular/core';
import { Message } from '../shared/models/message';
import { User } from '../shared/models/user';
import { MessageService } from '../core/services/message.service';

@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.scss']
})
export class MessageComponent implements OnInit {
  private newMessage;
  private userName: string = 'You';
  private text;

  messagecontent: string;

  constructor(private _messageService: MessageService) {}

  ngOnInit() {
  }

  addMessage() {
    console.log("submitted");
     this.newMessage = {
     user: this.userName,
     text: this.text
   }
   this._messageService.addMessage(this.newMessage);
  }
}
