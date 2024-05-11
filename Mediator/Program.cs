namespace Mediator;

class Program
{
    static void Main(string[] args)
    {
        ChatMediatorImpl chatroom = new ChatMediatorImpl();

        UserImpl user1 = new UserImpl("Timo", chatroom);
        UserImpl user2 = new UserImpl("Cherian", chatroom);
        UserImpl user3 = new UserImpl("Alina", chatroom);
        UserImpl user4 = new UserImpl("Anna", chatroom);

        chatroom.AddUser(user1);
        chatroom.AddUser(user2);
        chatroom.AddUser(user3);
        chatroom.AddUser(user4);

        //user1.SendMessage("Hello, everyone!");
        user1.SendPrivateMessage("Hey, how are you?", user3);// ""


        //ToDo expand the program and let the receiver knows who is the sender.
        Console.ReadKey();
    }
}

//IChatMediator
//User
//Impl
//UserImpl