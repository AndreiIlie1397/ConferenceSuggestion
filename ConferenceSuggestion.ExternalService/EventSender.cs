﻿using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConferenceSuggestion.ExternalService
{
    public class AllEventsHandler : INotificationHandler<INotification>
    {
        public Task Handle(INotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine(notification);
            return Task.CompletedTask;
        }
    }
}
