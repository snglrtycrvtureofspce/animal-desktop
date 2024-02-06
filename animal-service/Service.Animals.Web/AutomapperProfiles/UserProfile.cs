using AutoMapper;
using Service.Animals.Web.Models;
using Service.Animals.Web.ViewModels;

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