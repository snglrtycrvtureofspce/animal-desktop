using MediatR;

namespace Service.Animals.Web.Handlers.AnimalController.GetAnimal;

public class GetAnimalRequest : IRequest<GetAnimalResponse>
{
    public Guid Id { get; init; }
}