using MediatR;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.UserController.Get.Query;

/// <inheritdoc />
public class GetAllUsersQuery : IRequest<IEnumerable<UserViewModel>>
{
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
    public string SortBy { get; set; }
    public string Filter { get; set; }
}