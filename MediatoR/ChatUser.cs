using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR
{
    public class ChatUser : IUser
    {
        private readonly ChatMediatr _mediator;

        public ChatUser(ChatMediatr mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public string Name { get; }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{Name}:Sending message:{message}");
            _mediator.SendMessage(senderName: Name, message: message);
        }

        public void ReciveMessage(string senderName, string message)
        {
            Console.WriteLine($"{Name}:Recieve message'{message}' {senderName}!");
        }

    }
}
