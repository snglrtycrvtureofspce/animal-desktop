﻿namespace Service.Animals.Api.Infrastructure;

/// <summary>
/// Base entity interface
/// </summary>
public interface IEntity
{
    Guid Id { get; set; }
    DateTime CreatedDate { get; set; }
    DateTime ModificationDate { get; set; }
}