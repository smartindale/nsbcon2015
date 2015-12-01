using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using Slate.Projects.Contracts.Events;

namespace Slate.Notifications.Endpoint.Handlers
{
    public class ProjectPublishedHandler : IHandleMessages<IPublishedAProject>
    {
        private readonly IBus _bus;
        private static readonly ILog Log = LogManager.GetLogger(typeof (ProjectPublishedHandler));

        public ProjectPublishedHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(IPublishedAProject message)
        {
            Log.InfoFormat("Notifying users of published project {0}, version {1}",
                message.ProjectId,
                message.VersionNumber);

            //TODO: send out notifications
        }
    }
}
