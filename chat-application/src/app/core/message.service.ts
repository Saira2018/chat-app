import { Injectable } from '@angular/core';
import { Message } from '../shared/models/message';
import { MOCKMESSAGES } from '../core/mocks/mock-messages';
import { Observable, of } from 'rxjs';


@Injectable({
  providedIn: 'root'
})

export class MessageService {

  // getMessages(): Message [] {
  //   return MOCKMESSAGES;
  // }

  getMessages(): Observable<Message[]> {
    return of(MOCKMESSAGES);
  }

  

  addMessage(newPost) {
    //console.log(newPost);
    console.log(newPost);
    // this.MOCKMESSAGES.push(newPost)
  }

  constructor() { }
}
