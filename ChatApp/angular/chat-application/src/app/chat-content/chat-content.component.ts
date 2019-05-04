import { Component, OnInit } from '@angular/core';
import { Message } from '../shared/models/message';
import { User } from '../shared/models/user';
import { MessageService } from '../core/services/message.service';


@Component({
  selector: 'app-chat-content',
  templateUrl: './chat-content.component.html',
  styleUrls: ['./chat-content.component.scss']
})

export class ChatContentComponent implements OnInit {

  mockData: Message [];

  constructor(private _messageService: MessageService) {}

  getMessages(): void {
    this._messageService.getMessages()
      .subscribe(mockData => this.mockData = mockData);
  }


  ngOnInit() {
    this.getMessages();
  }
}
