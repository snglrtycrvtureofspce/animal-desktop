using MediatR;
using Microsoft.AspNetCore.Mvc;
using snglrtycrvtureofspce.Animal.Handlers.LocationController.CreateLocation;
using snglrtycrvtureofspce.Animal.Handlers.LocationController.DeleteLocation;
using snglrtycrvtureofspce.Animal.Handlers.LocationController.GetLocation;
using snglrtycrvtureofspce.Animal.Handlers.LocationController.UpdateLocation;
using Swashbuckle.AspNetCore.Annotations;

namespace snglrtycrvtureofspce.Animal.Controllers;

[Route("[controller]")]
[ApiController]
// [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Produces("application/json")]
public class LocationController(ISender sender) : ControllerBase
{
    /// <summary>
    /// The method provider possibility to create a location
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost(Name = "CreateLocation")]
    [SwaggerResponse(statusCode: StatusCodes.Status201Created, type: typeof(CreateLocationResponse))]
    public async Task<IActionResult> CreateLocation([FromBody] CreateLocationRequest request) =>
        Ok(await sender.Send(request));

    /// <summary>
    /// The method provider possibility to get a location by id
    /// </summary>
    /// <param name="id">Identifier of the location to be received</param>
    /// <returns></returns>
    [HttpGet("{id:guid}", Name = "GetLocation")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(GetLocationResponse))]
    public async Task<IActionResult> GetLocation(Guid id) => Ok(await sender.Send(new GetLocationRequest { Id = id }));
    
    /// <summary>
    /// The method provider possibility to update a location by id
    /// </summary>
    /// <param name="id">Identifier of the location to be received</param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut("{id:guid}", Name = "UpdateLocation")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(UpdateLocationResponse))]
    public async Task<IActionResult> UpdateLocation(Guid id, [FromBody] UpdateLocationRequest request)
    {
        request.Id = id;
        return Ok(await sender.Send(request));
    }

    /// <summary>
    /// The method provider possibility to delete a location by id
    /// </summary>
    /// <param name="id">Identifier of the location to be received</param>
    /// <returns></returns>
    [HttpDelete("{id:guid}", Name = "DeleteLocation")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(DeleteLocationResponse))]
    public async Task<IActionResult> DeleteLocation(Guid id) =>
        Ok(await sender.Send(new DeleteLocationRequest { Id = id }));
}