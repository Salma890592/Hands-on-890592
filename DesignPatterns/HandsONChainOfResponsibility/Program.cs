using System;

namespace HandsONChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest obj = new LeaveRequest() { LeaveDays = 10, Employee = "Salma" };
            LeaveRequest obj1 = new LeaveRequest() { LeaveDays = 5, Employee = "Shasa" };

            ILeaveRequestHandler leave = new SuperVisor();
            leave.HandleRequest(obj);
            leave.HandleRequest(obj1);

            Console.ReadLine();
        }
    }
}
