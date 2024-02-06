using AutoMapper;
using Service.Animals.Web.Models;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.AutomapperProfiles;

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