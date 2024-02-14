using MediatR;

namespace Service.Animals.Web.Handlers.AnimalsController.DeleteAnimal;

public class DeleteAnimalRequest : IRequest<DeleteAnimalResponse>
{
    public Guid Id { get; set; }
}