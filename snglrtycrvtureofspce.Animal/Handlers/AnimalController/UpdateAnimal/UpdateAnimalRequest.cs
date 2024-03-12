using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalController.UpdateAnimal;

public class UpdateAnimalRequest : IRequest<UpdateAnimalResponse>
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
    
    public Guid AnimalTypeId { get; set; }
}