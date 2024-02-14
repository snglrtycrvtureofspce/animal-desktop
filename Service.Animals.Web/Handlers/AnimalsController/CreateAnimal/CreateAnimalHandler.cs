using AutoMapper;
using FluentValidation;
using MediatR;
using Service.Animals.Web.Data;
using Service.Animals.Web.Data.Entities;

namespace Service.Animals.Web.Handlers.AnimalsController.CreateAnimal;

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
        
        var id = Guid.NewGuid();
        var invoice = new AnimalEntity
        {
            Id = id,
            InvoiceNumber = request.InvoiceNumber,
            Terms = request.Terms,
            Description = request.Description,
            DueDate = DateTime.UtcNow,
            InvoicePdfUrl = request.InvoicePdfUrl,
            InvoiceDate = DateTime.UtcNow,
            ApplicationId = request.ApplicationId,
            PartyId = request.PartyId,
            OrderId = request.OrderId,
            StatusId = request.StatusId
        };

        context.Animals.Add(invoice);
        await context.SaveChangesAsync(cancellationToken);

        var model = mapper.Map<InvoiceViewModel>(invoice);
        
        var response = new CreateInvoiceResponse
        {
            Message = "Invoice have been successfully created",
            StatusCode = StatusCodes.Status201Created,
            Item = model
        };

        return response;
    }
}