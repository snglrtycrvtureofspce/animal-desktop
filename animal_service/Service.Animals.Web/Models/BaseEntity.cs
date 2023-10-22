using Service.Animals.Api.Infrastructure;

namespace Service.Animals.Web.Models;

/// <summary>
/// Base model
/// </summary>
public class BaseEntity : IEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModificationDate { get; set; }
}