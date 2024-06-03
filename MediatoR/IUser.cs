using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR
{
    public interface IUser
    {
        public string Name { get; }
        void SendMessage(string message);
        void ReciveMessage(string senderName, string message);
    }
}
