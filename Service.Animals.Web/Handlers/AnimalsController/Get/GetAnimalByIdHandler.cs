using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Service.Animals.Web.Data;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.Handlers.AnimalsController.Get;

public class GetAnimalByIdHandler : IRequestHandler<GetAnimalByIdQuery, AnimalViewModel>
{
    private readonly AnimalsDbContext _context;
    private readonly IMapper _mapper;
    
    public GetAnimalByIdHandler(AnimalsDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<AnimalViewModel> Handle(GetAnimalByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _context.Animals
            .FirstOrDefaultAsync(u => u.Id == request.AnimalId, cancellationToken: cancellationToken);

        if (user == null)
        {
            throw new Exception($"User with ID {request.AnimalId} not found");
        }

        return _mapper.Map<AnimalViewModel>(user);
    }
}