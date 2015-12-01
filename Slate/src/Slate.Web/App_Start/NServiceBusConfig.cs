using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NServiceBus;

namespace Slate.Web.App_Start
{
    public static class NServiceBusConfig
    {
        public static IBus Bus { get; private set; }
        public static void Configure()
        {
            var configuration = new BusConfiguration();
            configuration.Conventions()
                .DefiningCommandsAs(m => m.Namespace != null && m.Namespace.Contains("Contracts.Commands"))
                .DefiningEventsAs(m => m.Namespace != null && m.Namespace.Contains("Contracts.Events"))
                .DefiningMessagesAs(m => m.Namespace != null && m.Namespace.Contains("Contracts.Messages"));
            configuration.UsePersistence<InMemoryPersistence>();
            NServiceBusConfig.Bus = NServiceBus.Bus.Create(configuration).Start();
        }
    }
}