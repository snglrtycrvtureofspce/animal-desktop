using AutoMapper;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.AutomapperProfiles;

public class LocationProfile : Profile
{
    public LocationProfile()
    {
        CreateMap<LocationEntity, LocationViewModel>();
    }
}