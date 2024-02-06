using MediatR;
using Service.Animals.Api.ViewModels;

namespace Service.Animals.Web.Handlers.AnimalsController.Get;

/// <inheritdoc />
public class GetAnimalByIdQuery : IRequest<AnimalViewModelSummary>
{
    public Guid AnimalId { get; set; }
}