using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Core.Middlewares;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.DeleteAnimalType;

public class DeleteAnimalTypeHandler(AnimalsDbContext context) : IRequestHandler<DeleteAnimalTypeRequest, 
    DeleteAnimalTypeResponse>
{
    public async Task<DeleteAnimalTypeResponse> Handle(DeleteAnimalTypeRequest request, 
        CancellationToken cancellationToken)
    {
        try
        {
            var animalType = await context.AnimalTypes
                .FirstOrDefaultAsync(f => f.Id == request.Id, 
                    cancellationToken: cancellationToken);

            if (animalType == null)
            {
                throw new ValidationException("Animal type not found",
                    new List<ValidationFailure>
                    {
                        new()
                        {
                            PropertyName = nameof(request.Id),
                            ErrorMessage = "Animal type not found",
                            ErrorCode = StatusCodes.Status404NotFound.ToString()
                        }
                    });
            }

            context.AnimalTypes.Remove(animalType);
            await context.SaveChangesAsync(cancellationToken);

            return new DeleteAnimalTypeResponse
            {
                Message = "Animal type have been successfully updated",
                StatusCode = StatusCodes.Status200OK,
                Item = request.Id.ToString()
            };
        }
        catch (DbUpdateException ex) when (IsForeignKeyViolationExceptionMiddleware.CheckForeignKeyViolation(ex,
                                               out var referencedObject))
        {
            return new DeleteAnimalTypeResponse
            {
                Message = $"Unable to delete animal type. It is referenced by {referencedObject}.",
                StatusCode = StatusCodes.Status400BadRequest,
                Item = request.Id.ToString()
            };
        }
    }
}