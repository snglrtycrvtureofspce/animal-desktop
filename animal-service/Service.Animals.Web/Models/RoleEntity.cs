namespace animal_service.Models;

/// <summary>
/// Role model
/// </summary>
public class RoleEntity : BaseEntity
{
    public string Name { get; set; }
    public virtual List<UserEntity> Users { get; set; }
}