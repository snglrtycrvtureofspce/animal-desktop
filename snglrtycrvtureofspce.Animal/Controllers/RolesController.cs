using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using snglrtycrvtureofspce.Animal.Handlers.RoleController.Delete;
using snglrtycrvtureofspce.Animal.Handlers.RoleController.Get;
using snglrtycrvtureofspce.Animal.Handlers.RoleController.Post.Command;
using snglrtycrvtureofspce.Animal.Handlers.RoleController.Put;
using snglrtycrvtureofspce.Animal.ViewModels;
using snglrtycrvtureofspce.Core.Base.Responses;

namespace snglrtycrvtureofspce.Animal.Controllers;

/// <summary>
/// Controller for interaction with the roles
/// </summary>
[Route("[controller]")]
[ApiController]
// [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Produces("application/json")]
public class RolesController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <inheritdoc />
    public RolesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// The method provider possibility to add a role to user
    /// </summary>
    [HttpPost("AddUserRole/{userId:guid}/roles/{roleId:guid}", Name = "AddUserRole")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<ActionResult<string>> AddUserRole(Guid userId, Guid roleId)
    {
        await _mediator.Send(new AddUserRoleCommand { UserId = userId, RoleId = roleId });
        return Ok($"Role added successfully for user: {userId}");
    }

    /// <summary>
    /// The method provider possibility to get a role by id 
    /// </summary>
    [HttpGet("GetRoleById/{roleId:guid}", Name = "GetRoleById")]
    [ProducesResponseType(typeof(ItemResponse<RoleViewModel>), StatusCodes.Status200OK)]
    [AllowAnonymous]
    public async Task<ItemResponse<RoleViewModel>> GetRoleById(Guid roleId)
    {
        var query = await _mediator.Send(new GetRoleByIdQuery { RoleId = roleId });

        return new ItemResponse<RoleViewModel>
        {
            Message = "The response was received successfully.",
            StatusCode = 200,
            Item = new RoleViewModel
            {
                Id = query.Id,
                CreatedDate = query.CreatedDate,
                ModificationDate = query.ModificationDate,
                Name = query.Name,
                Users = query.Users
            }
        };
    }

    /// <summary>
    /// The method provider possibility to create a role
    /// </summary>
    [HttpPost("CreateRole", Name = "CreateRole")]
    [ProducesResponseType(typeof(ItemResponse<RoleViewModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<ItemResponse<RoleViewModel>> CreateRole(CreateRoleCommand createRoleCommand)
    {
        var query = await _mediator.Send(createRoleCommand);

        return new ItemResponse<RoleViewModel>
        {
            Message = "Role created successfully.",
            StatusCode = 200,
            Item = new RoleViewModel
            {
                Id = query.Id,
                CreatedDate = query.CreatedDate,
                ModificationDate = query.ModificationDate,
                Name = query.Name,
                Users = query.Users
            }
        };
    }

    /// <summary>
    /// The method provider possibility to update a role
    /// </summary>
    [HttpPut("UpdateRole/{roleId:guid}", Name = "UpdateRole")]
    [ProducesResponseType(typeof(ItemResponse<RoleViewModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<ItemResponse<RoleViewModel>> UpdateRole(Guid roleId, UpdateRoleCommand updateRoleCommand)
    {
        updateRoleCommand.RoleId = roleId;
        var query = await _mediator.Send(updateRoleCommand);

        return new ItemResponse<RoleViewModel>
        {
            Message = "Role updated successfully.",
            StatusCode = 200,
            Item = new RoleViewModel
            {
                Id = query.Id,
                CreatedDate = query.CreatedDate,
                ModificationDate = query.ModificationDate,
                Name = query.Name
            }
        };
    }

    /// <summary>
    /// The method provider possibility to delete a role
    /// </summary>
    [HttpDelete("DeleteRole/{roleId:guid}", Name = "DeleteRole")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<ActionResult<string>> DeleteRole(Guid roleId)
    {
        await _mediator.Send(new DeleteRoleCommand { RoleId = roleId });
        return Ok("Role deleted successfully.");
    }
}