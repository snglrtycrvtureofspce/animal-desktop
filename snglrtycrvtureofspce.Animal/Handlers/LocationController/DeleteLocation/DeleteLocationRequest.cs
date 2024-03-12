using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.LocationController.DeleteLocation;

public class DeleteLocationRequest : IRequest<DeleteLocationResponse>
{
    public Guid Id { get; set; }
}