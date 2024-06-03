using MediatR;

ChatMediatr mediatr = new ChatMediatr();

ChatUser user1 = new ChatUser(mediatr, "User 1");
ChatUser user2 = new ChatUser(mediatr, "User 2");
ChatUser user3 = new ChatUser(mediatr, "User 3");

mediatr.RegisterUser(user1);
mediatr.RegisterUser(user2);
mediatr.RegisterUser(user3);

user1.SendMessage("Hello evryone");




