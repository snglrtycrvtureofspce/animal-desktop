using MediatR;

namespace Service.Animals.Web.Handlers.AnimalsController.Get;

public class GetAnimalQuery : IRequest<GetAnimalResponse>
{
    public Guid Id { get; init; }
}