using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.UpdateAnimalType;

public class UpdateAnimalTypeHandler(AnimalsDbContext context, IMapperBase mapper, 
    IValidator<UpdateAnimalTypeRequest> validator) : IRequestHandler<UpdateAnimalTypeRequest, UpdateAnimalTypeResponse>
{
    public async Task<UpdateAnimalTypeResponse> Handle(UpdateAnimalTypeRequest request, 
        CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var animalType = await context.AnimalTypes.FirstOrDefaultAsync(i => i.Id == request.Id, 
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

        animalType.Name = request.Name;
        animalType.Description = request.Description;

        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<AnimalTypeViewModel>(animalType);

        var response = new UpdateAnimalTypeResponse
        {
            Message = "Animal type have been successfully updated",
            StatusCode = StatusCodes.Status200OK,
            Item = model
        };

        return response;
    }
}