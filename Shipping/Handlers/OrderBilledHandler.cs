using System;
using NServiceBus;
using Billing.Messages;
using System.Threading.Tasks;
using NServiceBus.Logging;

namespace Shipping.Handlers
{
    internal class OrderBilledHandler : IHandleMessages<OrderBilled>
    {
        static ILog log = LogManager.GetLogger<OrderBilledHandler>();
        public Task Handle(OrderBilled message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderBilled, OrderId = {message.OrderId} - Should we ship now?");
            return Task.CompletedTask;
        }
    }
}
