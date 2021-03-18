using System;
using System.Collections.Generic;
using System.Text;

namespace HandsONChainOfResponsibility
{
    public interface ILeaveRequestHandler
    {


        ILeaveRequestHandler NextHandler { get; set; }

        void HandleRequest(LeaveRequest obj);
    }
}
