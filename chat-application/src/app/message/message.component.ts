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
  private userName: string = 'You';
  private text;
  message: Message

  constructor(private _messageService: MessageService) {}

  ngOnInit() {
  }

  addMessage() {
    const message = new Message (this.userName, this.text);
    this._messageService.addMessage(message);
  }
}
