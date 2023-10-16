using animal_service.Models;

namespace animal_service.ViewModels;

/// <summary>
/// ViewModel for the user
/// </summary>
public class UserViewModelSummary : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public virtual List<RoleViewModelSummary> Roles { get; set; }
    public virtual List<AnimalViewModelSummary> Animals { get; set; }
}