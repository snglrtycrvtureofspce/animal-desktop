using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.GetAnimalType;

public class GetAnimalTypeRequest : IRequest<GetAnimalTypeResponse>
{
    public Guid Id { get; init; }
}