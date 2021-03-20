using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCase
{
    public interface INotificationService
    {
        void AddEvent(INotificationObserver observer);
        void NotifyAdmin();
    }
}
