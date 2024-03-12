using AutoMapper;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.AutomapperProfiles;

public class AnimalTypeProfile : Profile
{
    public AnimalTypeProfile()
    {
        CreateMap<AnimalTypeEntity, AnimalTypeViewModel>();
    }
}