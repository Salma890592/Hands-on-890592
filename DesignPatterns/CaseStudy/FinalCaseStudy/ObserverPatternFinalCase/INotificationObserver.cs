using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCase
{
    public interface INotificationObserver
    {
        string Name { get; }

        int NoOfTickets { get; set; }
        string EventInformation { get; set; }
        void OnNotified();
    }
}
