using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.LocationController.CreateLocation;

public class CreateLocationRequest : IRequest<CreateLocationResponse>
{
    public string Name { get; set; }

    public string Description { get; set; }
    
    public double Latitude { get; set; }
    
    public double Longitude { get; set; }
}