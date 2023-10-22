namespace Service.Animals.Web.Models;

/// <summary>
/// User model
/// </summary>
public class UserEntity : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public virtual List<RoleEntity> Roles { get; set; }
    public virtual List<AnimalEntity> Animals { get; set; }
}