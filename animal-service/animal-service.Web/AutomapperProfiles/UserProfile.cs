using animal_service.Models;
using animal_service.ViewModels;
using AutoMapper;

namespace animal_service.AutomapperProfiles;

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