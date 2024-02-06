using snglrtycrvtureofspce.Core.Infrastructure;

namespace Service.Animals.Web.Models;

/// <summary>
/// Role model
/// </summary>
public class RoleEntity : IEntity
{
    #region IEntity
    public Guid Id { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime ModificationDate { get; set; }
    #endregion
    
    public string Name { get; set; }
    
    public virtual List<UserEntity> Users { get; set; }
}