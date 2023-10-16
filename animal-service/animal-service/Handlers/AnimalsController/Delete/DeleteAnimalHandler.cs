using animal_service.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace animal_service.Handlers.AnimalsController.Delete;

public class DeleteAnimalHandler : IRequestHandler<DeleteAnimalCommand, Unit>
{
    private readonly AnimalsDbContext _dbContext;

    public DeleteAnimalHandler(AnimalsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

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