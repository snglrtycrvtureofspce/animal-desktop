using AutoMapper;
using FluentValidation;
using MediatR;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.CreateAnimalType;

public class CreateAnimalTypeHandler(AnimalsDbContext context, IMapperBase mapper, 
    IValidator<CreateAnimalTypeRequest> validator) : IRequestHandler<CreateAnimalTypeRequest, CreateAnimalTypeResponse>
{
    public async Task<CreateAnimalTypeResponse> Handle(CreateAnimalTypeRequest request, 
        CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        var animalType = new AnimalTypeEntity
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description
        };

        context.AnimalTypes.Add(animalType);
        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<AnimalTypeViewModel>(animalType);

        var response = new CreateAnimalTypeResponse
        {
            Message = "Animal type have been successfully created",
            StatusCode = StatusCodes.Status201Created,
            Item = model
        };

        return response;
    }
}