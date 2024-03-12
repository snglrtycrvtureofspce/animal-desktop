using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.CreateAnimalType;

public class CreateAnimalTypeRequest : IRequest<CreateAnimalTypeResponse>
{
    public string Name { get; set; }

    public string Description { get; set; }
}