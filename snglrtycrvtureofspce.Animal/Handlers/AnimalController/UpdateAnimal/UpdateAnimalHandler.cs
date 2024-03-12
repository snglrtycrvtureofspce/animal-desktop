using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalController.UpdateAnimal;

public class UpdateAnimalHandler(
    AnimalsDbContext context,
    IMapperBase mapper,
    IValidator<UpdateAnimalRequest> validator) : IRequestHandler<UpdateAnimalRequest, UpdateAnimalResponse>
{
    public async Task<UpdateAnimalResponse> Handle(UpdateAnimalRequest request,
        CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var animal = await context.Animals.FirstOrDefaultAsync(i => i.Id == request.Id,
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

        animal.Name = request.Name;
        animal.Description = request.Description;
        animal.DateOfBirth = request.DateOfBirth;
        animal.Status = request.Status;
        animal.Breed = request.Breed;
        animal.PhotoUrl = request.PhotoUrl;

        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<AnimalViewModel>(animal);

        var response = new UpdateAnimalResponse
        {
            Message = "Animal have been successfully updated",
            StatusCode = StatusCodes.Status200OK,
            Item = model
        };

        return response;
    }
}