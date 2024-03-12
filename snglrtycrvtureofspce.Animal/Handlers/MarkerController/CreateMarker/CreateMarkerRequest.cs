using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.MarkerController.CreateMarker;

public class CreateMarkerRequest : IRequest<CreateMarkerResponse>
{
    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string LocationName { get; set; }
}