using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.Handlers.AnimalTypeController.GetAnimalType;

public class GetAnimalTypeHandler(AnimalsDbContext context, IMapperBase mapper) : IRequestHandler<GetAnimalTypeRequest,
    GetAnimalTypeResponse>
{
    public async Task<GetAnimalTypeResponse> Handle(GetAnimalTypeRequest request, CancellationToken cancellationToken)
    {
        var animalType = await context.AnimalTypes
            .FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken: cancellationToken);

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

        var model = mapper.Map<AnimalTypeViewModel>(animalType);

        var response = new GetAnimalTypeResponse
        {
            Message = "Animal type been successfully received",
            StatusCode = StatusCodes.Status200OK,
            Item = model
        };

        return response;
    }
}