using animal_service.Models;
using animal_service.ViewModels;
using AutoMapper;

namespace animal_service.AutomapperProfiles;

/// <summary>
/// Mapping profile for animal
/// </summary>
public class MarkerProfile : Profile
{
    /// <inheritdoc />
    public MarkerProfile()
    {
        CreateMap<MarkerEntity, MarkerViewModelSummary>();
    }
}