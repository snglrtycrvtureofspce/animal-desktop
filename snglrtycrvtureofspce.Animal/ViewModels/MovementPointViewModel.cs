namespace snglrtycrvtureofspce.Animal.ViewModels;

public class MovementPointViewModel
{
    #region IEntity
    public Guid Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModificationDate { get; set; }
    #endregion
    
    public Guid AnimalId { get; set; }
    
    public Guid LocationId { get; set; }
}