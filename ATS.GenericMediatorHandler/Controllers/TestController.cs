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
		private readonly ILogger<TestController> _logger;

		public TestController(IMediator mediator, ILogger<TestController> logger)
		{
			_mediator = mediator;
			_logger = logger;
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
