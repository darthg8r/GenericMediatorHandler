using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;

namespace ATS.GenericMediatorHandler.Mediatr
{
	public class ExchangeOrderRequestHandler<TEvent, TRequest> : IRequestHandler<TRequest, Unit>
		where TRequest : ExchangeOrderRequest<TEvent>
		where TEvent : ExchangeOrderEvent
	{
		private readonly ILogger<ExchangeOrderRequestHandler<TEvent, TRequest>> _logger;

		public ExchangeOrderRequestHandler(ILogger<ExchangeOrderRequestHandler<TEvent, TRequest>> logger)
		{
			_logger = logger;
		}

		public  Task<Unit> Handle(TRequest request, CancellationToken cancellationToken)
		{
			_logger.LogDebug("Handling request");

			return Task.FromResult(Unit.Value);
		}
	}
}
