import { User } from './user';

export class Message {
    user: User;
    text: string;
    
    constructor(username, text){
        this.user = new User(username);
        this.text = text;
    }
}
