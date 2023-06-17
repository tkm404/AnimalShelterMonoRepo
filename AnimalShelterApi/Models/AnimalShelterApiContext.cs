using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
        new Animal { AnimalId = 11, Name = "Laika", Species = "Dog", Breed = "Golden Retriever", Age = 4 },
        new Animal { AnimalId = 2, Name = "Enos", Species = "Ape", Breed = "Chimpanzee", Age = 5 },
        new Animal { AnimalId = 3, Name = "Dolly", Species = "Sheep", Breed = "Finn-Dorset", Age = 6 },
        new Animal { AnimalId = 4, Name = "Belka", Species = "Dog", Breed = "Terrier", Age = 6 },
        new Animal { AnimalId = 5, Name = "Strelka", Species = "Dog", Breed = "Terrier", Age = 7 },
        new Animal { AnimalId = 6, Name = "Ham", Species = "Ape", Breed = "Chimpanzee", Age = 3 },
        new Animal { AnimalId = 7, Name = "Koko", Species = "Ape", Breed = "Gorilla", Age = 46 },
        new Animal { AnimalId = 8, Name = "Elliot", Species = "Guinea Pig", Breed = "Teddy", Age = 4},
        new Animal { AnimalId = 9, Name = "Bandito", Species = "Armadillo", Breed = "Nine-Banded", Age = 3},
        new Animal { AnimalId = 10, Name = "Schroedinger", Species = "Cat", Breed = "Theoretical", Age = 5 }
      );
    }
  }
}
