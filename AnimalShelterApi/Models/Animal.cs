using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    public string Breed { get; set; }
    [Required]
    [Range(0, 200, ErrorMessage = "Age must be between 0 and 200")]
    public int Age { get; set; }
  }
}