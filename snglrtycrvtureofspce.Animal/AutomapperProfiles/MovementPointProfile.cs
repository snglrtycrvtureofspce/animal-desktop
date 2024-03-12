using AutoMapper;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.AutomapperProfiles;

public class MovementPointProfile : Profile
{
    public MovementPointProfile()
    {
        CreateMap<MovementPointEntity, MovementPointViewModel>();
    }
}