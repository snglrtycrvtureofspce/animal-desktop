using MediatR;

namespace Service.Animals.Web.Handlers.MarkerController.CreateMarker;

public class CreateMarkerRequest : IRequest<CreateMarkerResponse>
{
    public double Latitude { get; set; }
    
    public double Longitude { get; set; }
    
    public string LocationName { get; set; }
}