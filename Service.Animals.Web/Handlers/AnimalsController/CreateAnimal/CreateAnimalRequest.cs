using MediatR;

namespace Service.Animals.Web.Handlers.AnimalsController.CreateAnimal;

public class CreateAnimalRequest : IRequest<CreateAnimalResponse>
{
    public string Name { get; set; }
    
    public string PhotoUrl { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public string Description { get; set; }
    
    public string Status { get; set; }
    
    public string Breed { get; set; }
}