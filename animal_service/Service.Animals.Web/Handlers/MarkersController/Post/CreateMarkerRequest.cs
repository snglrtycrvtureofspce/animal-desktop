using MediatR;
using Service.Animals.Web.Models;

namespace Service.Animals.Web.Handlers.MarkersController.Post;

public class CreateMarkerRequest : IRequest<MarkerEntity>
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string LocationName { get; set; }
}