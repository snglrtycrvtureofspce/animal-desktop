using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.CreateAnimalType;
using snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.DeleteAnimalType;
using snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.GetAnimalType;
using snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.UpdateAnimalType;
using Swashbuckle.AspNetCore.Annotations;

namespace snglrtycrvtureofspce.Animal.Controllers;

[Route("[controller]")]
[ApiController]
[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Produces("application/json")]
public class AnimalTypeController(ISender sender) : ControllerBase
{
    /// <summary>
    /// The method provider possibility to create a animal type
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost(Name = "CreateAnimalType")]
    [SwaggerResponse(statusCode: StatusCodes.Status201Created, type: typeof(CreateAnimalTypeResponse))]
    public async Task<IActionResult> CreateAnimalType([FromBody] CreateAnimalTypeRequest request) =>
        Ok(await sender.Send(request));
    
    /// <summary>
    /// The method provider possibility to get a animal type by id
    /// </summary>
    /// <param name="id">Identifier of the animal type to be received</param>
    /// <returns></returns>
    [HttpGet("{id:guid}", Name = "GetAnimalType")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(GetAnimalTypeResponse))]
    public async Task<IActionResult> GetAnimalType(Guid id) => 
        Ok(await sender.Send(new GetAnimalTypeRequest { Id = id }));

    /// <summary>
    /// The method provider possibility to update a animal type by id
    /// </summary>
    /// <param name="id">Identifier of the animal type to be received</param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut("{id:guid}", Name = "UpdateAnimalType")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(UpdateAnimalTypeResponse))]
    public async Task<IActionResult> UpdateAnimalType(Guid id, [FromBody] UpdateAnimalTypeRequest request)
    {
        request.Id = id;
        return Ok(await sender.Send(request));
    }

    /// <summary>
    /// The method provider possibility to delete a animal type by id
    /// </summary>
    /// <param name="id">Identifier of the animal type to be received</param>
    /// <returns></returns>
    [HttpDelete("{id:guid}", Name = "DeleteAnimalType")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(DeleteAnimalTypeResponse))]
    public async Task<IActionResult> DeleteAnimalType(Guid id) =>
        Ok(await sender.Send(new DeleteAnimalTypeRequest { Id = id }));
}