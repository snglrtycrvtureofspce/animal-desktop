using MediatR;

namespace Service.Animals.Web.Handlers.MarkerController.GetMarker;

public class GetMarkerRequest : IRequest<GetMarkerResponse>
{
    public Guid Id { get; init; }
}