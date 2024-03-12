using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.MarkerController.UpdateMarker;

public class UpdateMarkerRequest : IRequest<UpdateMarkerResponse>
{
    public Guid Id { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public string LocationName { get; set; }
}