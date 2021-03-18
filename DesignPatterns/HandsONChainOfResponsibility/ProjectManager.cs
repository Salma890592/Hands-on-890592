using System;
using System.Collections.Generic;
using System.Text;

namespace HandsONChainOfResponsibility
{
    public class ProjectManager : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler { get { return nextHandler; } set { nextHandler = value; } }

        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays < 7)
                Console.WriteLine("Leave approved by ProjectManager");
            else
            {
                Console.WriteLine("Leave request rejected by ProjectManager and  passed to HR\n");
                NextHandler = new HR();
                NextHandler.HandleRequest(obj);

            }
        }
    }
}
