using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Animals.Web.Handlers.AnimalsController.Get;
using Service.Animals.Web.ViewModels;
using snglrtycrvtureofspce.Core.Base.Responses;

namespace Service.Animals.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
// [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Produces("application/json")]
public class AnimalController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <inheritdoc />
    public AnimalController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    /// <summary>
    /// The method provider possibility to get a animal by id
    /// </summary>
    /// <param name="id">Identifier of the animal to be received</param>
    /// <returns></returns>
    [HttpGet("{id:guid}", Name = "GetAnimal")]
    [ProducesResponseType(typeof(ItemResponse<AnimalViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAnimal(Guid id) =>
        Ok(await _mediator.Send(new GetAnimalQuery { Id = id }));
}
