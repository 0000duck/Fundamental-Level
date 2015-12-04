using _02.Animals.Enums;

namespace _02.Animals.Interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        
        int Age { get; set; }
        
        Gender Gender { get; set; } 
    }
}