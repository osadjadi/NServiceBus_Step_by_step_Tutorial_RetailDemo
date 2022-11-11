﻿using NServiceBus;
using Messages.Events;
using Billing.Messages;
using NServiceBus.Logging;
using System.Threading.Tasks;

namespace Billing.Handlers
{
    public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
    {
        static ILog log = LogManager.GetLogger<OrderPlacedHandler>();

        public Task Handle(OrderPlaced message, IMessageHandlerContext context)
        {
            log.Info($"Received OrderPlaced, OrderId = {message.OrderId} - Charging credit card...");

            var orderBilled = new OrderBilled 
            { 
                OrderId = message.OrderId 
            };
            
            return context.Publish(orderBilled);
        }
    }
}
