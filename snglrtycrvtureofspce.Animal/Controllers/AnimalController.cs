using MediatR;
using Microsoft.AspNetCore.Mvc;
using snglrtycrvtureofspce.Animal.Handlers.AnimalController.CreateAnimal;
using snglrtycrvtureofspce.Animal.Handlers.AnimalController.DeleteAnimal;
using snglrtycrvtureofspce.Animal.Handlers.AnimalController.GetAnimal;
using snglrtycrvtureofspce.Animal.Handlers.AnimalController.UpdateAnimal;
using Swashbuckle.AspNetCore.Annotations;

namespace snglrtycrvtureofspce.Animal.Controllers;

[Route("[controller]")]
[ApiController]
// [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Produces("application/json")]
public class AnimalController(ISender sender) : ControllerBase
{
    /// <summary>
    /// The method provider possibility to create a animal
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost(Name = "CreateAnimal")]
    [SwaggerResponse(statusCode: StatusCodes.Status201Created, type: typeof(CreateAnimalResponse))]
    public async Task<IActionResult> CreateAnimal([FromBody] CreateAnimalRequest request) =>
        Ok(await sender.Send(request));
    
    /// <summary>
    /// The method provider possibility to get a animal by id
    /// </summary>
    /// <param name="id">Identifier of the animal to be received</param>
    /// <returns></returns>
    [HttpGet("{id:guid}", Name = "GetAnimal")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(GetAnimalResponse))]
    public async Task<IActionResult> GetAnimal(Guid id) => Ok(await sender.Send(new GetAnimalRequest { Id = id }));

    /// <summary>
    /// The method provider possibility to update a animal by id
    /// </summary>
    /// <param name="id">Identifier of the animal to be received</param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut("{id:guid}", Name = "UpdateAnimal")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(UpdateAnimalResponse))]
    public async Task<IActionResult> UpdateAnimal(Guid id, [FromBody] UpdateAnimalRequest request)
    {
        request.Id = id;
        return Ok(await sender.Send(request));
    }

    /// <summary>
    /// The method provider possibility to delete a animal by id
    /// </summary>
    /// <param name="id">Identifier of the animal to be received</param>
    /// <returns></returns>
    [HttpDelete("{id:guid}", Name = "DeleteAnimal")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(DeleteAnimalResponse))]
    public async Task<IActionResult> DeleteAnimal(Guid id) =>
        Ok(await sender.Send(new DeleteAnimalRequest { Id = id }));
}