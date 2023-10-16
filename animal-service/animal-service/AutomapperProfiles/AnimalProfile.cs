using animal_service.Models;
using animal_service.ViewModels;
using AutoMapper;

namespace animal_service.AutomapperProfiles;

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