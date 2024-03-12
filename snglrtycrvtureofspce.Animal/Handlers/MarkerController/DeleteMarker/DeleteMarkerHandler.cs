using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Core.Middlewares;

namespace snglrtycrvtureofspce.Animal.Handlers.MarkerController.DeleteMarker;

public class DeleteMarkerHandler(AnimalsDbContext context) : IRequestHandler<DeleteMarkerRequest, DeleteMarkerResponse>
{
    public async Task<DeleteMarkerResponse> Handle(DeleteMarkerRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var marker = await context.Markers.FirstOrDefaultAsync(f => f.Id == request.Id,
                cancellationToken: cancellationToken);

            if (marker == null)
            {
                throw new ValidationException("Marker not found",
                    new List<ValidationFailure>
                    {
                        new()
                        {
                            PropertyName = nameof(request.Id),
                            ErrorMessage = "Marker not found",
                            ErrorCode = StatusCodes.Status404NotFound.ToString()
                        }
                    });
            }

            context.Markers.Remove(marker);
            await context.SaveChangesAsync(cancellationToken);

            return new DeleteMarkerResponse
            {
                Message = "Marker have been successfully updated",
                StatusCode = StatusCodes.Status200OK,
                Item = request.Id.ToString()
            };
        }
        catch (DbUpdateException ex) when (IsForeignKeyViolationExceptionMiddleware.CheckForeignKeyViolation(ex,
                                               out var referencedObject))
        {
            return new DeleteMarkerResponse
            {
                Message = $"Unable to delete marker. It is referenced by {referencedObject}.",
                StatusCode = StatusCodes.Status400BadRequest,
                Item = request.Id.ToString()
            };
        }
    }
}