namespace animal_service.Models;

/// <summary>
/// UserRole model
/// </summary>
public class UserRoleEntity
{
    public Guid UserId { get; set; }
    public virtual UserEntity UserEntity { get; set; }
    public Guid RoleId { get; set; }
    public virtual RoleEntity RoleEntity { get; set; }
}