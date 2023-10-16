using animal_service.Models;
using MediatR;

namespace animal_service.Handlers.MarkersController.Post;

public class CreateMarkerRequest : IRequest<MarkerEntity>
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string LocationName { get; set; }
}