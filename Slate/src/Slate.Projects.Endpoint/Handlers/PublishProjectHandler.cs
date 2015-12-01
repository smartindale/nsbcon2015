using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using Slate.Projects.Contracts.Commands;
using Slate.Projects.Contracts.Events;

namespace Slate.Projects.Endpoint.Handlers
{
    public class PublishProjectHandler : IHandleMessages<PublishProject>
    {
        private readonly IBus _bus;
        private static readonly ILog Log = LogManager.GetLogger(typeof (PublishProjectHandler));

        public PublishProjectHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(PublishProject message)
        {
            Log.InfoFormat("Publishing project {0}...",
                message.ProjectId);

            //TODO: generate a version number 

            //TODO: save the publish

            _bus.Publish<IPublishedAProject>(m =>
            {
                m.VersionNumber = Guid.NewGuid().ToString();
                m.ProjectId = message.ProjectId;
            });
        }
    }
}
