using MediatR;

namespace Service.Animals.Web.Handlers.AnimalController.DeleteAnimal;

public class DeleteAnimalRequest : IRequest<DeleteAnimalResponse>
{
    public Guid Id { get; init; }
}