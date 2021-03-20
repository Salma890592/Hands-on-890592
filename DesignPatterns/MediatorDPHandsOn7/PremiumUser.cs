﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDPHandsOn7
{
    public class PremiumUser : IUser
    {
        public string Name { get; set; }

        ChatMediator chat = new ChatMediator();

        public void RecieveMesage(IUser u, string message)
        {
            Console.WriteLine(message + " receive by " + this.Name);
        }

        public void SendMesage(string message)
        {
            chat.SendMessage(this, message);
        }
    }
}
