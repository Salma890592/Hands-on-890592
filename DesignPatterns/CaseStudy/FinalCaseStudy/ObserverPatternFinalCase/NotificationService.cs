using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCase
{
    public class NotificationService : INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();

        public void AddEvent(INotificationObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine(observer.EventInformation + " is added\n\nList of Subscribers\n\n");
            foreach (var ob in observers)
            {
                Console.WriteLine(ob.EventInformation);
            }
        }

        public void NotifyAdmin()
        {
            foreach (var ob in observers)
            {
                if (ob.NoOfTickets > 100)
                {
                    ob.OnNotified();
                }

            }

        }
    }
}
