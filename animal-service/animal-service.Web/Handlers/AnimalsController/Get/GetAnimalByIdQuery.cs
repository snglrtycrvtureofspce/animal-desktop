using animal_service.ViewModels;
using MediatR;

namespace animal_service.Handlers.AnimalsController.Get;

/// <inheritdoc />
public class GetAnimalByIdQuery : IRequest<AnimalViewModelSummary>
{
    public Guid AnimalId { get; set; }
}