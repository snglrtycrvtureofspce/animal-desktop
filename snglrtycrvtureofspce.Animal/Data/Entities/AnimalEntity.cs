using snglrtycrvtureofspce.Core.Base.Infrastructure;

namespace snglrtycrvtureofspce.Animal.Data.Entities;

public class AnimalEntity : IEntity
{
    #region IEntity

    public Guid Id { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModificationDate { get; set; }

    #endregion

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string Status { get; set; } // "потерян" или "найден"

    public string Breed { get; set; } // порода

    public string PhotoUrl { get; set; }

    public virtual List<UserEntity> Users { get; set; }

    public virtual List<MarkerEntity> Markers { get; set; }
}