using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDPHandsOn7
{
    public interface IUser
    {
        string Name { get; set; }
        void RecieveMesage(IUser u, string message);
        void SendMesage(string message);
    }
}
