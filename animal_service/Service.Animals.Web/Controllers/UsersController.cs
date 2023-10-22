using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Animals.Api.Infrastructure;
using Service.Animals.Api.ViewModels;
using Service.Animals.Web.Handlers.UserController.Delete;
using Service.Animals.Web.Handlers.UserController.Get.Query;
using Service.Animals.Web.Handlers.UserController.Post;
using Service.Animals.Web.Handlers.UserController.Put;

namespace Service.Animals.Web.Controllers;

/// <summary>
/// Controller for interaction with the users
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
    /// The method provider possibility to delete a user
    /// </summary>
    [HttpDelete("DeleteUser/{userId:guid}", Name = "DeleteUser")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<ActionResult<string>> DeleteUser(Guid userId)
    {
        await _mediator.Send(new DeleteUserCommand { UserId = userId });
        return Ok("User deleted successfully.");
    }
}