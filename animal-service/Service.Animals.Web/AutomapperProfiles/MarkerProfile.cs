using AutoMapper;
using Service.Animals.Api.ViewModels;
using Service.Animals.Web.Models;

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