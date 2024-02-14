using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Service.Animals.Web.Data;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.AnimalsController.GetAnimal;

public class GetAnimalHandler(AnimalsDbContext context, IMapperBase mapper) : IRequestHandler<GetAnimalRequest, 
    GetAnimalResponse>
{
    public async Task<GetAnimalResponse> Handle(GetAnimalRequest request, CancellationToken cancellationToken)
    {
        var animal = await context.Animals
            .FirstOrDefaultAsync(u => u.Id == request.Id, cancellationToken: cancellationToken);

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

        var model = mapper.Map<AnimalViewModel>(animal);

        var response = new GetAnimalResponse
        {
            Message = "Animal have been successfully received",
            StatusCode = StatusCodes.Status200OK,
            Item = model
        };

        return response;
    }
}