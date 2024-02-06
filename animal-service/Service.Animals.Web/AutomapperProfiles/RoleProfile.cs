using AutoMapper;
using Service.Animals.Web.Models;
using Service.Animals.Web.ViewModels;

namespace Service.Animals.Web.AutomapperProfiles;

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