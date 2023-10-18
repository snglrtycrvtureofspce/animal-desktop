namespace animal_service.Models;

/// <summary>
/// Marker model
/// </summary>
public class MarkerEntity : BaseEntity      
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string LocationName { get; set; }
    public virtual List<AnimalEntity> Animals { get; set; }
}