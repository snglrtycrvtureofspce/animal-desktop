using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.UpdateAnimalType;

public class UpdateAnimalTypeRequest : IRequest<UpdateAnimalTypeResponse>
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}