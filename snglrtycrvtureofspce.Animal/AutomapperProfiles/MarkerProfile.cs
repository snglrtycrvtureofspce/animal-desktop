using AutoMapper;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.AutomapperProfiles;

public class MarkerProfile : Profile
{
    public MarkerProfile()
    {
        CreateMap<MarkerEntity, MarkerViewModel>();
    }
}