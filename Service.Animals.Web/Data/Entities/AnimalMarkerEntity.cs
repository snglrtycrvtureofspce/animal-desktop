namespace Service.Animals.Web.Data.Entities;

public class AnimalMarkerEntity
{
    public Guid AnimalId { get; set; }
    public virtual AnimalEntity Animal { get; set; }
    public Guid MarkerId { get; set; }
    public virtual MarkerEntity Marker { get; set; }
}