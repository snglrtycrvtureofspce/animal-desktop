using MediatR;

namespace Service.Animals.Web.Handlers.MarkerController.DeleteMarker;

public class DeleteMarkerRequest : IRequest<DeleteMarkerResponse>
{
    public Guid Id { get; init; }
}