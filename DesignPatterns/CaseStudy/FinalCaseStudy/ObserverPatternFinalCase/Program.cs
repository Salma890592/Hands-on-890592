using System;
using System.Collections.Generic;

namespace ObserverPatternFinalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminObserver event1 = new AdminObserver(101, "Audio Release Event");
            AdminObserver event2 = new AdminObserver(70, "Mother's Day Event");
            AdminObserver event3 = new AdminObserver(20, "Drama Event");
            AdminObserver event4 = new AdminObserver(122, "Children's day event");


            NotificationService service = new NotificationService();
            service.AddEvent(event1);
            service.AddEvent(event2);
            service.AddEvent(event3);
            service.AddEvent(event4);
            service.NotifyAdmin();

            Console.ReadLine();
        }
    }
}
