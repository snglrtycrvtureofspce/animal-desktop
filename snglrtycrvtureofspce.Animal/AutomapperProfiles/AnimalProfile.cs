using AutoMapper;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.AutomapperProfiles;

public class AnimalProfile : Profile
{
    public AnimalProfile()
    {
        CreateMap<AnimalEntity, AnimalViewModel>();
    }
}