using System.Collections.Generic;
using System.Diagnostics.Tracing;
using ItAcademy.PropertyCenter.Core.Logging;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging;

namespace ItAcademy.PropertyCenter.App_Start
{
    public class LoggingConfig
    {
        public static void Configure()
        {
            List<EventSource> eventSources = new List<EventSource>() { DomainEventSource.Log, SiteEventSource.Log };

            ObservableEventListener logListener = new ObservableEventListener();

            foreach (var eventSource in eventSources)
            {
                logListener.EnableEvents(eventSource, EventLevel.LogAlways, Keywords.All);
            }


            logListener.LogToFlatFile("./Log.txt");
        }
    }
}