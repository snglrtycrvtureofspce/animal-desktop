﻿using snglrtycrvtureofspce.Core.Infrastructure;

namespace Service.Animals.Web.Models;

/// <summary>
/// Marker model
/// </summary>
public class MarkerEntity : IEntity 
{
    #region IEntity
    public Guid Id { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime ModificationDate { get; set; }
    #endregion
    
    public double Latitude { get; set; }
    
    public double Longitude { get; set; }
    
    public string LocationName { get; set; }
    
    public virtual List<AnimalEntity> Animals { get; set; }
}