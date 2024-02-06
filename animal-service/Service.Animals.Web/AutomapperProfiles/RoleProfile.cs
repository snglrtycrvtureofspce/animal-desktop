using AutoMapper;
using Service.Animals.Api.ViewModels;
using Service.Animals.Web.Models;

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