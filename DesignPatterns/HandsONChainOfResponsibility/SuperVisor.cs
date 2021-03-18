using System;
using System.Collections.Generic;
using System.Text;

namespace HandsONChainOfResponsibility
{
    class SuperVisor : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler { get => nextHandler; set => nextHandler = value; }

        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays < 3)
                Console.WriteLine("Leave approved by SuperVisor");
            else
            {
                Console.WriteLine("Leave request rejected by Supervisor and  passed to ProjectManager\n");

                NextHandler = new ProjectManager();
                NextHandler.HandleRequest(obj);

            }
        }


    }
}
