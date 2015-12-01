using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NServiceBus;
using Slate.Pricing.Contracts.Events;

namespace Slate.Web.Handlers
{
    public class ProjectBudgetHandler : IHandleMessages<IRecalculatedAProjectBudget>
    {

        public void Handle(IRecalculatedAProjectBudget message)
        {
            
        }
    }
}