using AutoMapper;
using FluentValidation;
using MediatR;
using Service.Animals.Web.Data;
using Service.Animals.Web.Data.Entities;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.AnimalController.CreateAnimal;

public class CreateAnimalHandler(AnimalsDbContext context, IMapperBase mapper, 
    IValidator<CreateAnimalRequest> validator) : IRequestHandler<CreateAnimalRequest, CreateAnimalResponse>
{
    public async Task<CreateAnimalResponse> Handle(CreateAnimalRequest request, CancellationToken cancellationToken)
    {
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }
        
        var animal = new AnimalEntity
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            PhotoUrl = request.PhotoUrl,
            DateOfBirth = request.DateOfBirth,
            Description = request.Description,
            Status = request.Status,
            Breed = request.Breed
        };

        context.Animals.Add(animal);
        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<AnimalViewModel>(animal);
        
        var response = new CreateAnimalResponse
        {
            Message = "Animal have been successfully created",
            StatusCode = StatusCodes.Status201Created,
            Item = model
        };

        return response;
    }
}