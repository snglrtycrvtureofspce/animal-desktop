using Service.Animals.Api.Infrastructure;

namespace Service.Animals.Api.ViewModels;

/// <summary>
/// ViewModel for the user
/// </summary>
public class UserViewModelSummary : IEntity
{
    #region IEntity
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModificationDate { get; set; }
    #endregion
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public virtual List<RoleViewModelSummary> Roles { get; set; }
    public virtual List<AnimalViewModelSummary> Animals { get; set; }
}