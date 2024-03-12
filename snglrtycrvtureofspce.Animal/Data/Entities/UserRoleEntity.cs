namespace snglrtycrvtureofspce.Animal.Data.Entities;

public class UserRoleEntity
{
    public Guid UserId { get; set; }
    
    public virtual UserEntity User { get; set; }
    
    public Guid RoleId { get; set; }
    
    public virtual RoleEntity Role { get; set; }
}