using System;
using MediatR;

namespace ATS.GenericMediatorHandler.Mediatr
{
	public class ExchangeOrderRequest<T> : DocumentMessage, IRequest<Unit> where T : ExchangeOrderEvent
	{

		public T Event { get; set; }

		public ExchangeOrderRequest()
		{

		}
	}
}