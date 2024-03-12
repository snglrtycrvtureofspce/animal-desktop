using AutoMapper;
using Microsoft.AspNetCore.Http;
using Moq;
using Moq.EntityFrameworkCore;
using snglrtycrvtureofspce.Animal.Data;
using snglrtycrvtureofspce.Animal.Data.Entities;
using snglrtycrvtureofspce.Animal.Handlers.AnimalController.GetAnimal;

namespace snglrtycrvtureofspce.Animal.Tests;

public class AnimalControllerTest
{
    private readonly Mock<AnimalsDbContext> _context = new();

    private readonly Mock<IMapper> _mapper = new();
    
    [SetUp]
    public void Setup()
    {
        var guid = new Guid("2c12e095-71fb-4e0f-a3c0-05d6fd3276af");

        var animalEntities = new List<AnimalEntity>
        {
            new() { Id = guid }
        }.AsQueryable();
        
        _context.Setup(c => c.Animals).ReturnsDbSet(animalEntities);
    }
    
    [Test(Author = "Aleksandr Zenevich", Description = "The controller provider possibility to get a animal by id")]
    public async Task Should_get_animal()
    {
        var handler = new GetAnimalHandler(_context.Object, _mapper.Object);

        var response = await handler.Handle(new GetAnimalRequest
        {
            Id = new Guid("2c12e095-71fb-4e0f-a3c0-05d6fd3276af")
        }, CancellationToken.None);

        Assert.That(response, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(response.StatusCode, Is.EqualTo(StatusCodes.Status200OK));
            Assert.That(response.Message, Is.EqualTo("Animal have been successfully received"));
        });
    }
}