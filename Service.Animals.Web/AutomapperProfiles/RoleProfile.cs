using AutoMapper;
using Service.Animals.Web.Data.Entities;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.AutomapperProfiles;

public class RoleProfile : Profile
{
    public RoleProfile()
    {
        CreateMap<RoleEntity, RoleViewModel>();
    }
}