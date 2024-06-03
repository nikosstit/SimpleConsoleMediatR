This is a simple console MediatR pattern explanation. It is a ChatUsers example. 

In this example you can see an: 

  1 IUser interface, with two abstruct methods, SendMessage and ReciveMessage.
  2 A ChatUser Class witch implement the interface. This class inject in the constuctor the ChatMediatr class and a prop Name. Need the ChatMediator because throu this could comunicate with oher users.
  3 The Last one is the ChatMediatr. Into this class there are exist the SendMessage method in order to comunicate between users. There are exist a private list of users too. And a method RegisterUser in order to register the users.

  In tne Program class Create a ChatMediatr 
  
  ChatMediatr mediatr = new ChatMediatr();

  and three users:

  ChatUser user1 = new ChatUser(mediatr, "User 1");
  ChatUser user2 = new ChatUser(mediatr, "User 2");
  ChatUser user3 = new ChatUser(mediatr, "User 3");
