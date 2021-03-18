using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public interface INotificationObserver
    {
        string Name { get; }
        void OnServerDown();
    }
}
