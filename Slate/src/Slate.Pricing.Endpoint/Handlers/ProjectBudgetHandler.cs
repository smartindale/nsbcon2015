using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;
using Slate.Pricing.Contracts.Events;
using Slate.Pricing.Endpoint.Domain;
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

            var repository = new ProjectBudgetRepository();
            var budget = repository.Get(message.ProjectId);
            budget.HighCost += new Random().Next(1000) + 1000;
            budget.LowCost += new Random().Next(1000);
            _bus.Publish<IRecalculatedAProjectBudget>(m =>
            {
                m.ProjectId = message.ProjectId;
                m.LowCost = budget.LowCost;
                m.HighCost = budget.HighCost;
            });
        }
    }
}
