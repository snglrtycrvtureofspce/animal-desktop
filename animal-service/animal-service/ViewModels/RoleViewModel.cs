using animal_service.Models;

namespace animal_service.ViewModels;

/// <summary>
/// ViewModel for the role
/// </summary>
public class RoleViewModelSummary : BaseEntity
{
    public string Name { get; set; }
    public virtual List<UserViewModelSummary> Users { get; set; }
}