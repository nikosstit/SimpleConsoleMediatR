using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR
{
    public class ChatMediatr
    {
        private readonly List<IUser> _users;

        public ChatMediatr()
        {
            _users = new List<IUser>();
        }

        public void RegisterUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string senderName, string message)
        {
            foreach (var user in _users)
            {
                if (!user.Name.Equals(senderName))
                {
                    user.ReciveMessage(senderName, message);
                }
            }
        }

    }
}
