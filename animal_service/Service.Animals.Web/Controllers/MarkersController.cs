using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Service.Animals.Web.Controllers;

/// <summary>
/// Controller for interaction with the markers
/// </summary>
[Route("api/[controller]")]
[ApiController]
// [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Produces("application/json")]
public class MarkersController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <inheritdoc />
    public MarkersController(IMediator mediator)
    {
        _mediator = mediator;
    }
}