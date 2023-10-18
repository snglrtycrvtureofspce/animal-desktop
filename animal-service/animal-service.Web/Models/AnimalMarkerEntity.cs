namespace animal_service.Models;

/// <summary>
/// AnimalMarker model
/// </summary>
public class AnimalMarkerEntity
{
    public Guid AnimalId { get; set; }
    public virtual AnimalEntity AnimalEntity { get; set; }
    public Guid MarkerId { get; set; }
    public virtual MarkerEntity MarkerEntity { get; set; }
}