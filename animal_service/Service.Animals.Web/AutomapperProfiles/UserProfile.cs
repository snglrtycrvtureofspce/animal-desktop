using AutoMapper;
using Service.Animals.Api.ViewModels;
using Service.Animals.Web.Models;

namespace Service.Animals.Web.AutomapperProfiles;

/// <summary>
/// Mapping profile for user
/// </summary>
public class UserProfile : Profile
{
    /// <inheritdoc />
    public UserProfile()
    {
        CreateMap<UserEntity, UserViewModelSummary>();
    }
}