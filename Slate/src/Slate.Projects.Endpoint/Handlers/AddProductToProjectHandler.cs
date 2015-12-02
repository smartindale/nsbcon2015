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
    public class AddProductToProjectHandler : IHandleMessages<AddProductToProject>
    {
        private readonly IBus _bus;
        private static readonly ILog Log = LogManager.GetLogger(typeof (AddProductToProjectHandler));
        public AddProductToProjectHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(AddProductToProject message)
        {
            Log.InfoFormat("Adding product {0} to project {1} at ({2},{3}",
                message.ProductId,
                message.ProjectId, 
                message.X, 
                message.Y);

            //TODO: add product to the database

            _bus.Publish<IAddedAProductToAProject>(m =>
            {
                m.ProductId = message.ProductId;
                m.ProjectId = message.ProjectId;
                m.X = message.X;
                m.Y = message.Y;
                m.Id = Guid.NewGuid().ToString();
            });
        }
    }
}
