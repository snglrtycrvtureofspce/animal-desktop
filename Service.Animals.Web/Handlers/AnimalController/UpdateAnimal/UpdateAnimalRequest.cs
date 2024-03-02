using MediatR;

namespace Service.Animals.Web.Handlers.AnimalController.UpdateAnimal;

public class UpdateAnimalRequest : IRequest<UpdateAnimalResponse>
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public string PhotoUrl { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public string Description { get; set; }
    
    public string Status { get; set; }
    
    public string Breed { get; set; }
}