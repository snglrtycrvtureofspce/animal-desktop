using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Core.Middlewares;

namespace snglrtycrvtureofspce.Animal.Handlers.LocationController.DeleteLocation;

public class DeleteLocationHandler(AnimalsDbContext context) : IRequestHandler<DeleteLocationRequest, 
    DeleteLocationResponse>
{
    public async Task<DeleteLocationResponse> Handle(DeleteLocationRequest request, 
        CancellationToken cancellationToken)
    {
        try
        {
            var location = await context.Locations
                .FirstOrDefaultAsync(f => f.Id == request.Id, cancellationToken: cancellationToken);

            if (location == null)
            {
                throw new ValidationException("Location not found",
                    new List<ValidationFailure>
                    {
                        new()
                        {
                            PropertyName = nameof(request.Id),
                            ErrorMessage = "Location not found",
                            ErrorCode = StatusCodes.Status404NotFound.ToString()
                        }
                    });
            }

            context.Locations.Remove(location);
            await context.SaveChangesAsync(cancellationToken);

            return new DeleteLocationResponse
            {
                Message = "Location have been successfully updated",
                StatusCode = StatusCodes.Status200OK,
                Item = request.Id.ToString()
            };
        }
        catch (DbUpdateException ex) when (IsForeignKeyViolationExceptionMiddleware.CheckForeignKeyViolation(ex,
                                               out var referencedObject))
        {
            return new DeleteLocationResponse
            {
                Message = $"Unable to delete location. It is referenced by {referencedObject}.",
                StatusCode = StatusCodes.Status400BadRequest,
                Item = request.Id.ToString()
            };
        }
    }
}