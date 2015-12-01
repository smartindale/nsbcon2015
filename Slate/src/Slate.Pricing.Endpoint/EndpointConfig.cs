
namespace Slate.Pricing.Endpoint
{
    using NServiceBus;

    /*
		This class configures this endpoint as a Server. More information about how to configure the NServiceBus host
		can be found here: http://particular.net/articles/the-nservicebus-host
	*/
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.Conventions()
                .DefiningCommandsAs(m => m.Namespace != null && m.Namespace.Contains("Contracts.Commands"))
                .DefiningEventsAs(m => m.Namespace != null && m.Namespace.Contains("Contracts.Events"))
                .DefiningMessagesAs(m => m.Namespace != null && m.Namespace.Contains("Contracts.Messages"));
            configuration.UsePersistence<InMemoryPersistence>();
        }
    }
}
