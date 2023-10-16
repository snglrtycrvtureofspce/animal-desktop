using animal_service.Handlers.UserController.Delete;
using animal_service.Handlers.UserController.Get.Query;
using animal_service.Handlers.UserController.Post.Command;
using animal_service.Handlers.UserController.Put;
using animal_service.Infrastructure;
using animal_service.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace animal_service.Controllers;

/// <summary>
/// Controller for interaction with the user and roles
/// </summary>
[Route("api/[controller]")]
[ApiController]
//[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
[Produces("application/json")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <inheritdoc />
    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    /// <summary>
    /// The method provider possibility to get all users
    /// </summary>
    [HttpGet("GetUsers")]
    [ProducesResponseType(typeof(IEnumerable<UserViewModelSummary>), StatusCodes.Status200OK)]
    [AllowAnonymous]
    public async Task<IEnumerable<UserViewModelSummary>> GetUsers([FromQuery] GetAllUsersQuery query)
    {
        return await _mediator.Send(query);
    }

    /// <summary>
    /// The method provider possibility to get a user by id 
    /// </summary>
    [HttpGet("GetUserById/{userId:guid}", Name = "GetUserById")]
    [ProducesResponseType(typeof(ItemResponse<UserViewModelSummary>), StatusCodes.Status200OK)]
    [AllowAnonymous]
    public async Task<ItemResponse<UserViewModelSummary>> GetUserById(Guid userId)
    {
        var query = await _mediator.Send(new GetUserByIdQuery { UserId = userId });
        
        return new ItemResponse<UserViewModelSummary>
        {
            Message = "The response was received successfully.",
            StatusCode = 200,
            Item = new UserViewModelSummary
            {
                Id = query.Id,
                CreatedDate = query.CreatedDate,
                ModificationDate = query.ModificationDate,
                Username = query.Username,
                Password = query.Password,
                Name = query.Name,
                Age = query.Age,
                Email = query.Email,
                Roles = query.Roles
            }
        };
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
    /// The method provider possibility to create a user
    /// </summary>
    [HttpPost("CreateUser", Name = "CreateUser")]
    [ProducesResponseType(typeof(ItemResponse<UserViewModelSummary>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<ItemResponse<UserViewModelSummary>> CreateUser(CreateUserCommand createUserCommand)
    {
        var query = await _mediator.Send(createUserCommand);
        
        return new ItemResponse<UserViewModelSummary>
        {
            Message = "User created successfully.",
            StatusCode = 200,
            Item = new UserViewModelSummary
            {
                Id = query.Id,
                CreatedDate = query.CreatedDate,
                ModificationDate = query.ModificationDate,
                Username = query.Username,
                Password = query.Password,
                Name = query.Name,
                Age = query.Age,
                Email = query.Email,
                Roles = query.Roles
            }
        };
    }
    
    /// <summary>
    /// The method provider possibility to create a role
    /// </summary>
    [HttpPost("CreateRole", Name = "CreateRole")]
    [ProducesResponseType(typeof(ItemResponse<RoleViewModelSummary>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<ItemResponse<RoleViewModelSummary>> CreateRole(CreateRoleCommand createRoleCommand)
    {
        var query = await _mediator.Send(createRoleCommand);
        
        return new ItemResponse<RoleViewModelSummary>
        {
            Message = "Role created successfully.",
            StatusCode = 200,
            Item = new RoleViewModelSummary
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
    /// The method provider possibility to update a user
    /// </summary>
    [HttpPut("UpdateUser/{userId:guid}", Name = "UpdateUser")]
    [ProducesResponseType(typeof(ItemResponse<UserViewModelSummary>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<ItemResponse<UserViewModelSummary>> UpdateUser(Guid userId, UpdateUserCommand updateUserCommand)
    {
        updateUserCommand.UserId = userId;
        var query = await _mediator.Send(updateUserCommand);
        
        return new ItemResponse<UserViewModelSummary>
        {
            Message = "User updated successfully.",
            StatusCode = 200,
            Item = new UserViewModelSummary
            {
                Id = query.Id,
                CreatedDate = query.CreatedDate,
                ModificationDate = query.ModificationDate,
                Username = query.Username,
                Password = query.Password,
                Name = query.Name,
                Age = query.Age,
                Email = query.Email,
                Roles = query.Roles
            }
        };
    }
    
    /// <summary>
    /// The method provider possibility to update a role
    /// </summary>
    [HttpPut("UpdateRole/{roleId:guid}", Name = "UpdateRole")]
    [ProducesResponseType(typeof(ItemResponse<RoleViewModelSummary>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ValidationErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<ItemResponse<RoleViewModelSummary>> UpdateRole(Guid roleId, UpdateRoleCommand updateRoleCommand)
    {
        updateRoleCommand.RoleId = roleId;
        var query = await _mediator.Send(updateRoleCommand);
        
        return new ItemResponse<RoleViewModelSummary>
        {
            Message = "Role updated successfully.",
            StatusCode = 200,
            Item = new RoleViewModelSummary
            {
                Id = query.Id,
                CreatedDate = query.CreatedDate,
                ModificationDate = query.ModificationDate,
                Name = query.Name
            }
        };
    }

    /// <summary>
    /// The method provider possibility to delete a user
    /// </summary>
    [HttpDelete("DeleteUser/{userId:guid}", Name = "DeleteUser")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<ActionResult<string>> DeleteUser(Guid userId)
    {
        await _mediator.Send(new DeleteUserCommand { UserId = userId });
        return Ok("User deleted successfully.");
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