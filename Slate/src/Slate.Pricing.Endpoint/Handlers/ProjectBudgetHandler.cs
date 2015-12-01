using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using Slate.Pricing.Contracts.Events;
using Slate.Projects.Contracts.Events;

namespace Slate.Pricing.Endpoint.Handlers
{
    public class ProjectBudgetHandler : IHandleMessages<IAddedAProductToAProject>
    {
        private readonly IBus _bus;
        private static readonly ILog Log = LogManager.GetLogger(typeof(ProjectBudgetHandler));

        public ProjectBudgetHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(IAddedAProductToAProject message)
        {
            Log.InfoFormat("Updating budget for project {0} after product {1} was added...",
                message.ProjectId,
                message.ProductId);

            //TODO: recalculate budget

            _bus.Publish<IRecalculatedAProjectBudget>(m =>
            {
                m.ProjectId = message.ProjectId;
                m.LowCost = new Random().Next(100000);
                m.HighCost = new Random().Next(100000) + 100000;
            });
        }
    }
}
