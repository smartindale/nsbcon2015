using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using NServiceBus;
using Slate.Projects.Contracts.Events;
using Slate.Web.Hubs;

namespace Slate.Web.Handlers
{
    public class ProductAddedHandler : IHandleMessages<IAddedAProductToAProject>
    {
        public ProductAddedHandler()
        {
            
        }

        public void Handle(IAddedAProductToAProject message)
        {
            GlobalHost.ConnectionManager.GetHubContext<ProjectHub>()
                .Clients
                //.All
                .Group(GroupNames.Project(message.ProjectId))
                .productAddedToProject(message);
        }
    }
}