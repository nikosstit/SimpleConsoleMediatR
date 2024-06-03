# MediatR Pattern Explanation: ChatUsers Example

This example demonstrates a simple console application using the MediatR pattern with a ChatUsers scenario.

## Overview

In this example, you'll see:

1. **`IUser` Interface**: Defines two abstract methods, `SendMessage` and `ReceiveMessage`.
2. **`ChatUser` Class**: Implements the `IUser` interface. This class injects the `ChatMediator` class and has a property `Name`. It needs the `ChatMediator` to communicate with other users.
3. **`ChatMediator` Class**: Contains the `SendMessage` method for communication between users. It also maintains a private list of users and provides a `RegisterUser` method to register users.

## Implementation Steps

### 1. Define the `IUser` Interface
```csharp
public interface IUser
{
    void SendMessage(string message);
    void ReceiveMessage(string message);
}

### 2. Create the ChatUser Class

public class ChatUser : IUser
{
    private ChatMediator _mediator;
    public string Name { get; }

    public ChatUser(ChatMediator mediator, string name)
    {
        _mediator = mediator;
        Name = name;
    }

    public void SendMessage(string message)
    {
        _mediator.SendMessage(message, this);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{Name} received: {message}");
    }
}

### 3. Implement the ChatMediator Class
public class ChatMediator
{
    private List<ChatUser> _users = new List<ChatUser>();

    public void RegisterUser(ChatUser user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, ChatUser sender)
    {
        foreach (var user in _users)
        {
            if (user != sender)
            {
                user.ReceiveMessage(message);
            }
        }
    }
}

### 4. Set Up the Program Class
class Program
{
    static void Main(string[] args)
    {
        ChatMediator mediator = new ChatMediator();

        ChatUser user1 = new ChatUser(mediator, "User 1");
        ChatUser user2 = new ChatUser(mediator, "User 2");
        ChatUser user3 = new ChatUser(mediator, "User 3");

        mediator.RegisterUser(user1);
        mediator.RegisterUser(user2);
        mediator.RegisterUser(user3);

        user1.SendMessage("Hello everyone");
    }
}


Explanation
Create a ChatMediator instance

ChatMediator mediator = new ChatMediator();

Create and register three users

ChatUser user1 = new ChatUser(mediator, "User 1");
ChatUser user2 = new ChatUser(mediator, "User 2");
ChatUser user3 = new ChatUser(mediator, "User 3");

mediator.RegisterUser(user1);
mediator.RegisterUser(user2);
mediator.RegisterUser(user3);

Send a message from user1

user1.SendMessage("Hello everyone");

When user1 sends a message, the mediator ensures that the other users (user2 and user3) receive it.
