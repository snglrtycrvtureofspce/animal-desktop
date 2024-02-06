using AutoMapper;
using Service.Animals.Web.Models;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.AutomapperProfiles;

/// <summary>
/// Mapping profile for animal
/// </summary>
public class AnimalProfile : Profile
{
    /// <inheritdoc />
    public AnimalProfile()
    {
        CreateMap<AnimalEntity, AnimalViewModelSummary>();
    }
}