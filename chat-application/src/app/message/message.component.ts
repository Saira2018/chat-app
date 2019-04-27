import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-message',
  templateUrl: './message.component.html',
  styleUrls: ['./message.component.scss']
})
export class MessageComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  messageContent = 'write your message here';

  sendMessage() {
    //sends message to database
    console.log('button clicked: message sent = ', this.messageContent);
  }



  handleClick(){
    console.log(this.messageContent);
  }
}
