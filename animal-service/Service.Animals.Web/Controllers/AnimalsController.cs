using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Animals.Web.Handlers.AnimalsController.Get;
using Service.Animals.Web.ViewModels;
using snglrtycrvtureofspce.Core.Infrastructure;

namespace Service.Animals.Web.Controllers;

/// <summary>
/// Controller for interaction with the animals
/// </summary>
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
    [HttpGet("GetAnimalById/{animalId:guid}", Name = "GetAnimalById")]
    [ProducesResponseType(typeof(ItemResponse<AnimalViewModelSummary>), StatusCodes.Status200OK)]
    [AllowAnonymous]
    public async Task<ItemResponse<AnimalViewModelSummary>> GetAnimalById(Guid animalId)
    {
        var query = await _mediator.Send(new GetAnimalByIdQuery { AnimalId = animalId });
        
        return new ItemResponse<AnimalViewModelSummary>
        {
            Message = "The response was received successfully.",
            StatusCode = 200,
            Item = new AnimalViewModelSummary
            {
               Id = query.Id,
               CreatedDate = query.CreatedDate,
               ModificationDate = query.ModificationDate,
               Name = query.Name,
               PhotoUrl = query.PhotoUrl,
               DateOfBirth = query.DateOfBirth,
               Description = query.Description,
               Status = query.Status,
               Breed = query.Breed,
               Users = query.Users,
               Markers = query.Markers
            }
        };
    }
}
