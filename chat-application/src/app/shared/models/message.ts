import { User } from './user';

export class Message {
    user: string;
    //user: User;
    text: string;
    
    constructor(user, text){
        this.user = user;
        this.text = text;
    }
}
