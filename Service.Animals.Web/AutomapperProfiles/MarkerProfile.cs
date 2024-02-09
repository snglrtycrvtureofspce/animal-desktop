using AutoMapper;
using Service.Animals.Web.Data.Entities;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.AutomapperProfiles;

public class MarkerProfile : Profile
{
    public MarkerProfile()
    {
        CreateMap<MarkerEntity, MarkerViewModel>();
    }
}