using AutoMapper;
using Service.Animals.Api.ViewModels;
using Service.Animals.Web.Models;

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