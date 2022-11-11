using NServiceBus;
using Messages.Events;
using NServiceBus.Logging;
using System.Threading.Tasks;

namespace Shipping.Handlers
{
    internal class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        static ILog log = LogManager.GetLogger<OrderPlacedHandler>();
        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderPlaced, OrderId = {message.OrderId} - Should we ship now?");
            return Task.CompletedTask;
        }
    }
}
