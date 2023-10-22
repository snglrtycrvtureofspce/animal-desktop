using MediatR;
using Microsoft.EntityFrameworkCore;
using Service.Animals.Web.Data;

namespace Service.Animals.Web.Handlers.AnimalsController.Delete;

/// <summary>
/// Handler for the DeleteAnimal method
/// </summary>
public class DeleteAnimalHandler : IRequestHandler<DeleteAnimalCommand, Unit>
{
    private readonly AnimalsDbContext _dbContext;

    /// <summary>
    /// Constructor with params for DeleteAnimalHandler
    /// </summary>
    /// <param name="dbContext"></param>
    public DeleteAnimalHandler(AnimalsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<Unit> Handle(DeleteAnimalCommand request, CancellationToken cancellationToken)
    {
        var animal = await _dbContext.Animals.FirstOrDefaultAsync(a => a.Id == request.Id,
            cancellationToken: cancellationToken);

        if (animal != null)
        {
            _dbContext.Animals.Remove(animal);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        return Unit.Value;
    }
}