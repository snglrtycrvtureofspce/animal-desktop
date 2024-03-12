using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.MarkerController.DeleteMarker;

public class DeleteMarkerRequest : IRequest<DeleteMarkerResponse>
{
    public Guid Id { get; init; }
}