using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDPHandsOn7
{
    public class ChatMediator : IChatMediator
    {
        public List<IUser> users = new List<IUser>();
        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(IUser u, string message)
        {
            foreach (var user in users)
            {
                if (user != u)
                    user.RecieveMesage(u, message);
            }
        }
    }
}
