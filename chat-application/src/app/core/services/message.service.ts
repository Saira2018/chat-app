import { Injectable } from '@angular/core';
import { Message } from '../../shared/models/message';
import { MOCKMESSAGES } from '../mocks/mock-messages';
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})

export class MessageService {

  constructor() { }

  getMessages(): Observable<Message[]> {
    return of(MOCKMESSAGES);
  }

  addMessage(newMessage) {
    console.log(newMessage);
    MOCKMESSAGES.push(newMessage);
  }

}
