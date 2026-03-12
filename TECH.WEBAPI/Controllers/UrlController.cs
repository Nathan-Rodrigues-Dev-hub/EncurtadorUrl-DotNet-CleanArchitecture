using MediatR;
using Microsoft.AspNetCore.Mvc;
using TECH.APPLICATION.Commands;
using TECH.APPLICATION.Queries;

namespace TECH.WEBAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UrlController : ControllerBase
{
    private readonly IMediator _mediator;

    public UrlController(IMediator mediator) => _mediator = mediator;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUrlCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(new { ShortCode = result });
    }
    
    [HttpGet("{shortCode}")]
    public async Task<IActionResult> Get(string shortCode)
    {
        var longUrl = await _mediator.Send(new ListarLongUrlQuery(shortCode));
        return Redirect(longUrl);
    }
}