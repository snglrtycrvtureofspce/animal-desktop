using MediatR;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalController.GetAnimal;

public class GetAnimalRequest : IRequest<GetAnimalResponse>
{
    public Guid Id { get; init; }
}