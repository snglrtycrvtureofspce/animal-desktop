using animal_service.Data;
using animal_service.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace animal_service.Handlers.AnimalsController.Get;

/// <summary>
/// Handler for the GetAnimalById method
/// </summary>
public class GetAnimalByIdHandler : IRequestHandler<GetAnimalByIdQuery, AnimalViewModelSummary>
{
    private readonly AnimalsDbContext _context;
    private readonly IMapper _mapper;
    
    /// <summary>
    /// Constructor with params for GetAnimalByIdHandler
    /// </summary>
    /// <param name="context"></param>
    /// <param name="mapper"></param>
    public GetAnimalByIdHandler(AnimalsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<AnimalViewModelSummary> Handle(GetAnimalByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Animals
            .FirstOrDefaultAsync(u => u.Id == request.AnimalId, cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"User with ID {request.AnimalId} not found");
        }

        return _mapper.Map<AnimalViewModelSummary>(user);
    }
}