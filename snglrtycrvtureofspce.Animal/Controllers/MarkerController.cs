using MediatR;
using Microsoft.AspNetCore.Mvc;
using snglrtycrvtureofspce.Animal.Handlers.MarkerController.CreateMarker;
using snglrtycrvtureofspce.Animal.Handlers.MarkerController.DeleteMarker;
using snglrtycrvtureofspce.Animal.Handlers.MarkerController.GetMarker;
using snglrtycrvtureofspce.Animal.Handlers.MarkerController.UpdateMarker;
using Swashbuckle.AspNetCore.Annotations;

namespace snglrtycrvtureofspce.Animal.Controllers;

[Route("[controller]")]
[ApiController]
// [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Produces("application/json")]
public class MarkerController(ISender sender) : ControllerBase
{
    /// <summary>
    /// The method provider possibility to get a marker by id
    /// </summary>
    /// <param name="id">Identifier of the marker to be received</param>
    /// <returns></returns>
    [HttpGet("{id:guid}", Name = "GetMarker")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(GetMarkerResponse))]
    public async Task<IActionResult> GetMarker(Guid id) =>
        Ok(await sender.Send(new GetMarkerRequest { Id = id }));

    /// <summary>
    /// The method provider possibility to create a marker
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPost(Name = "CreateMarker")]
    [SwaggerResponse(statusCode: StatusCodes.Status201Created, type: typeof(CreateMarkerResponse))]
    public async Task<IActionResult> CreateMarker([FromBody] CreateMarkerRequest request) =>
        Ok(await sender.Send(request));

    /// <summary>
    /// The method provider possibility to update a marker by id
    /// </summary>
    /// <param name="id">Identifier of the marker to be received</param>
    /// <param name="request"></param>
    /// <returns></returns>
    [HttpPut("{id:guid}", Name = "UpdateMarker")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(UpdateMarkerResponse))]
    public async Task<IActionResult> UpdateMarker(Guid id, [FromBody] UpdateMarkerRequest request)
    {
        request.Id = id;
        return Ok(await sender.Send(request));
    }

    /// <summary>
    /// The method provider possibility to delete a marker by id
    /// </summary>
    /// <param name="id">Identifier of the marker to be received</param>
    /// <returns></returns>
    [HttpDelete("{id:guid}", Name = "DeleteMarker")]
    [SwaggerResponse(statusCode: StatusCodes.Status200OK, type: typeof(DeleteMarkerResponse))]
    public async Task<IActionResult> DeleteMarker(Guid id) =>
        Ok(await sender.Send(new DeleteMarkerRequest { Id = id }));
}