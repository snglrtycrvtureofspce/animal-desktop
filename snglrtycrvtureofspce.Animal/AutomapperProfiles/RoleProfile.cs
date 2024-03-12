using AutoMapper;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.ViewModels;

namespace snglrtycrvtureofspce.Animal.AutomapperProfiles;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<RoleEntity, RoleViewModel>();
    }
}