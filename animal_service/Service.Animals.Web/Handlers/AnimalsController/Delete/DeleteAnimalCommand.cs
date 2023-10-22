using MediatR;

namespace Service.Animals.Web.Handlers.AnimalsController.Delete;

/// <inheritdoc />
public class DeleteAnimalCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}