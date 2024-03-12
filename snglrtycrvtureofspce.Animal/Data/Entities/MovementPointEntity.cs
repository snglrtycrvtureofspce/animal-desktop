using snglrtycrvtureofspce.Core.Base.Infrastructure;

namespace snglrtycrvtureofspce.Animal.Data.Entities;

public class MovementPointEntity : IEntity
{
    #region IEntity
    public Guid Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModificationDate { get; set; }
    #endregion
    
    public Guid AnimalId { get; set; }
    
    public virtual AnimalEntity Animal { get; set; }
    
    public Guid LocationId { get; set; }
    
    public virtual LocationEntity Location { get; set; }
}