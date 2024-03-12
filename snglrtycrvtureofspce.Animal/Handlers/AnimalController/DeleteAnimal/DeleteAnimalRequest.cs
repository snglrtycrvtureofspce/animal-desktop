using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalController.DeleteAnimal;

public class DeleteAnimalRequest : IRequest<DeleteAnimalResponse>
{
    public Guid Id { get; init; }
}