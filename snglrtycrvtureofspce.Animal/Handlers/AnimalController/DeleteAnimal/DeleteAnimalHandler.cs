using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Core.Middlewares;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalController.DeleteAnimal;

public class DeleteAnimalHandler(AnimalsDbContext context) : IRequestHandler<DeleteAnimalRequest, DeleteAnimalResponse>
{
    public async Task<DeleteAnimalResponse> Handle(DeleteAnimalRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var animal = await context.Animals.FirstOrDefaultAsync(f => f.Id == request.Id,
                cancellationToken: cancellationToken);

            if (animal == null)
            {
                throw new ValidationException("Animal not found",
                    new List<ValidationFailure>
                    {
                        new()
                        {
                            PropertyName = nameof(request.Id),
                            ErrorMessage = "Animal not found",
                            ErrorCode = StatusCodes.Status404NotFound.ToString()
                        }
                    });
            }

            context.Animals.Remove(animal);
            await context.SaveChangesAsync(cancellationToken);

            return new DeleteAnimalResponse
            {
                Message = "Animal have been successfully updated",
                StatusCode = StatusCodes.Status200OK,
                Item = request.Id.ToString()
            };
        }
        catch (DbUpdateException ex) when (IsForeignKeyViolationExceptionMiddleware.CheckForeignKeyViolation(ex,
                                               out var referencedObject))
        {
            return new DeleteAnimalResponse
            {
                Message = $"Unable to delete animal. It is referenced by {referencedObject}.",
                StatusCode = StatusCodes.Status400BadRequest,
                Item = request.Id.ToString()
            };
        }
    }
}