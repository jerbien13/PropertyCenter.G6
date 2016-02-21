using System;
using System.Diagnostics.Tracing;

namespace ItAcademy.PropertyCenter.Core.Logging
{
    public class SiteEventSource : EventSource
    {
        private static readonly Lazy<SiteEventSource> Instance =
               new Lazy<SiteEventSource>(() => new SiteEventSource());

        public static SiteEventSource Log { get { return Instance.Value; } }

        public class Keywords
        {
            public const EventKeywords Page = (EventKeywords)1;
            public const EventKeywords Database = (EventKeywords)2;
            public const EventKeywords Diagnostic = (EventKeywords)4;
            public const EventKeywords Perf = (EventKeywords)8;
        }

        public class Tasks
        {
            public const EventTask Page = (EventTask)1;
            public const EventTask DbQuery = (EventTask)2;
            public const EventTask Service = (EventTask)4;
            public const EventTask Controller = (EventTask)8;
        }

        private SiteEventSource() { }

        [Event(1, Message = "Application Failure: {0}",
            Level = EventLevel.Critical, Keywords = Keywords.Diagnostic)]
        public void Failure(string message)
        {
            WriteEvent(1, message);
        }

        [Event(2, Message = "Page Error: {0}",
            Level = EventLevel.Error, Keywords = Keywords.Page, Task = Tasks.Page)]
        public void PageError(string message)
        {
            WriteEvent(2, message);
        }

        [Event(3, Message = "Service Error: {0}",
            Level = EventLevel.Error, Keywords = Keywords.Page, Task = Tasks.Service)]
        public void ServiceError(string message)
        {
            WriteEvent(3, message);
        }

        [Event(4, Message = "Info: {0}",
            Level = EventLevel.Informational, Keywords = Keywords.Page, Task = Tasks.Controller)]
        public void ControllerInfo(string message)
        {
            WriteEvent(4, message);
        }
    }
}
