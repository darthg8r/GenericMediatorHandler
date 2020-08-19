using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATS.GenericMediatorHandler.Mediatr;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ATS.GenericMediatorHandler.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		private readonly IMediator _mediator;
		private readonly IRequestHandler<ExchangeOrderRequest<ExchangeOrderResponseSuccessEvent>, Unit> _handler;
		private readonly ILogger<TestController> _logger;

		public TestController(IMediator mediator, IRequestHandler<ExchangeOrderRequest<ExchangeOrderResponseSuccessEvent>, Unit> handler, ILogger<TestController> logger)
		{
			_mediator = mediator;
			_logger = logger;

			// Problematic handler is injected just fine here.
			_handler = handler;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			
			await _mediator.Send(new ExchangeOrderRequest<ExchangeOrderResponseSuccessEvent>()
			{
				Event = new ExchangeOrderResponseSuccessEvent()
			});

			return Ok();
		}
	}
}
