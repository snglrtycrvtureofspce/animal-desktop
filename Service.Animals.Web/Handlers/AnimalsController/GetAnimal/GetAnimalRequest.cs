using MediatR;

namespace Service.Animals.Web.Handlers.AnimalsController.GetAnimal;

public class GetAnimalRequest : IRequest<GetAnimalResponse>
{
    public Guid Id { get; init; }
}