using MediatR;

namespace animal_service.Handlers.AnimalsController.Delete;

/// <inheritdoc />
public class DeleteAnimalCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}