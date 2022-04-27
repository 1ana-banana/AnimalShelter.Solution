using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
                .HasData(
                  new Animal { AnimalId = 1, Name = "Nyangs", Species = "Cat", Age = 3, Gender = "Male" },
                  new Animal { AnimalId = 2, Name = "Popeyes", Species = "Cat", Age = 4, Gender = "Male" },
                  new Animal { AnimalId = 3, Name = "Dunkin", Species = "Cat", Age = 1, Gender = "Female" },
                  new Animal { AnimalId = 4, Name = "Sadcat", Species = "Cat", Age = 2, Gender = "Female" },
                  new Animal { AnimalId = 5, Name = "Inu", Species = "Dog", Age = 3, Gender = "Female" },
                  new Animal { AnimalId = 6, Name = "Maru", Species = "Dog", Age = 6, Gender = "Male" },
                  new Animal { AnimalId = 7, Name = "Kissy", Species = "Dog", Age = 5, Gender = "Male" },
                  new Animal { AnimalId = 8, Name = "Mlem", Species = "Cat", Age = 10, Gender = "Male" },
                  new Animal { AnimalId = 9, Name = "Applebees", Species = "Cat", Age = 100, Gender = "Male" },
                  new Animal { AnimalId = 10, Name = "Greg", Species = "Dog", Age = 5, Gender = "Male" }
                );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}               