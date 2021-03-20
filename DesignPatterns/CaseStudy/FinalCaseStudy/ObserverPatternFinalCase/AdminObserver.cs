using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCase
{
    class AdminObserver : INotificationObserver
    {

        public string Name { get { return "Admin"; } }
        public int noOfTickets;
        public string eventInformation;
        public int NoOfTickets { get { return noOfTickets; } set { this.noOfTickets = value; } }
        public string EventInformation { get { return eventInformation; } set { this.eventInformation = value; } }

        public AdminObserver(int noOfTickets, string eventInformation)
        {
            this.noOfTickets = noOfTickets;
            this.eventInformation = eventInformation;
        }

        public void OnNotified()
        {

            Console.WriteLine("\nNotification has been received for event " + eventInformation + " by " + Name + " with " + noOfTickets + " Tickets");
        }
    }
}
