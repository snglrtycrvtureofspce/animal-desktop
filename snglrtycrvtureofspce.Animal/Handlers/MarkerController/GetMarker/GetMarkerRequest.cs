using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.MarkerController.GetMarker;

public class GetMarkerRequest : IRequest<GetMarkerResponse>
{
    public Guid Id { get; init; }
}