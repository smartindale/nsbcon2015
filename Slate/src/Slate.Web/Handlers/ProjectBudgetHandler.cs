using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Infrastructure;
using NServiceBus;
using Slate.Pricing.Contracts.Events;
using Slate.Web.Hubs;

namespace Slate.Web.Handlers
{
    public class ProjectBudgetHandler : IHandleMessages<IRecalculatedAProjectBudget>
    {

        public void Handle(IRecalculatedAProjectBudget message)
        {
            GlobalHost.ConnectionManager.GetHubContext<PricingHub>()
                .Clients
                //.All
                .Group(GroupNames.Project(message.ProjectId))
                .projectBudgetRecalculated(message);
        }
    }
}