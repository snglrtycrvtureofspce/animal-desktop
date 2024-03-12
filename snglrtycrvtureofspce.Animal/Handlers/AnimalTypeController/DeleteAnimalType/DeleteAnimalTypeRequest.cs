using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.DeleteAnimalType;

public class DeleteAnimalTypeRequest : IRequest<DeleteAnimalTypeResponse>
{
    public Guid Id { get; init; }
}