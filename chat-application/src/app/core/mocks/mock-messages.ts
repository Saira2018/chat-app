import { Message } from '../../shared/models/message';
import { User } from '../../shared/models/user';
export const MOCKMESSAGES: Message[] = [
    {user: new User('Sarah'), text: 'I love to draw'},
    {user: new User('Steven'), text: 'I love to play football'},
    {user: new User('Merlin'), text: 'I love to sleep, groan and eat'},
    {user: new User('John'), text: 'I love to get out in the garden'},

]

