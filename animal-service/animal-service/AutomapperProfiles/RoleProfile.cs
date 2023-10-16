using animal_service.Models;
using animal_service.ViewModels;
using AutoMapper;

namespace animal_service.AutomapperProfiles;

/// <summary>
/// Mapping profile for role
/// </summary>
public class RoleProfile : Profile
{
    /// <inheritdoc />
    public RoleProfile()
    {
        CreateMap<RoleEntity, RoleViewModelSummary>();
    }
}