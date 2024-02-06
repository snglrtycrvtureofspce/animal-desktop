using snglrtycrvtureofspce.Core.Infrastructure;

namespace Service.Animals.Web.ViewModels;

/// <summary>
/// ViewModel for the role
/// </summary>
public class RoleViewModelSummary : IEntity
{
    #region IEntity
    public Guid Id { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime ModificationDate { get; set; }
    #endregion
    
    public string Name { get; set; }
    
    public virtual List<UserViewModelSummary> Users { get; set; }
}