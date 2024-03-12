using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalController.CreateAnimal;

public class CreateAnimalRequest : IRequest<CreateAnimalResponse>
{
    public string Name { get; set; }

    public string Description { get; set; }
    
    public Guid AnimalTypeId { get; set; }
}