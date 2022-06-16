using FirstRealApp.Models.PoodleEntity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace FirstRealApp.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Poodle>? Poodles { get; set; }

        public DbSet<PoodleSize>? PoodleSizes { get; set; }

        public DbSet<PoodleColor>? PoodleColors { get; set; }

 

        

        


        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            builder.Entity<PoodleColor>().HasData(
                new PoodleColor() { Id = 1, Name = "Black" },
                new PoodleColor() { Id = 2, Name = "White" },
                new PoodleColor() { Id = 3, Name = "Brown" },
                new PoodleColor() { Id = 4, Name = "Gray"},
                new PoodleColor() { Id = 5, Name = "Apricot" },
                new PoodleColor() { Id = 6, Name = "Red" },
                new PoodleColor() { Id = 7, Name = "Black and tan" }
                );

           

            builder.Entity<PoodleSize>().HasData(
                new PoodleSize() { Id = 1, Name = "Toy"},
                new PoodleSize() { Id = 2, Name = "Miniature" },
                new PoodleSize() { Id = 3, Name = "Medium" },
                new PoodleSize() { Id = 4, Name = "Standard"}


                );

            builder.Entity<Poodle>().HasData(
                new Poodle() { Id = 1, Name="Toy Love Story Don Juan", DateOfBirth= new DateTime(2020, 2 ,1), GeneticTests =true, PedigreeNumber="JR 70883", PoodleColorId = 6, PoodleSizeId = 2, Image = "https://i.imgur.com/oWXLx57.jpeg" },
                new Poodle() { Id = 2, Name="Cici", DateOfBirth = new DateTime(2020, 11, 14), GeneticTests =false,  PedigreeNumber="JR 81231", PoodleColorId = 5, PoodleSizeId = 2, Image = "https://i.imgur.com/7RetPeR.jpg" },
                new Poodle() { Id = 3, Name = "Greta Garbo Von Apalusso", DateOfBirth = new DateTime(2018, 11, 4), GeneticTests = true, PedigreeNumber = "JR 70883", PoodleColorId = 5, PoodleSizeId = 2, Image = "https://i.imgur.com/gHWcJsQ.jpeg" },
                new Poodle() { Id = 4, Name = "Scarlet Rain  Von Apalusso", DateOfBirth = new DateTime(2020, 11, 3), GeneticTests = true, PedigreeNumber = "JR 70883", PoodleColorId = 6, PoodleSizeId = 1, Image = "https://i.imgur.com/2jlGebh.jpeg" },
                new Poodle() { Id = 5, Name="Skyler Von Apalusso", DateOfBirth = new DateTime(2020, 11, 3), GeneticTests =false, PedigreeNumber="JR 70883", PoodleColorId = 6, PoodleSizeId = 2, Image = "https://i.imgur.com/nuBvd3X.jpeg" },
                new Poodle() { Id = 6, Name = "Loko Loko Crveni Mayestoso", DateOfBirth = new DateTime(2017, 05, 13), GeneticTests = true, PedigreeNumber = "JR 70883", PoodleColorId = 7, PoodleSizeId = 1, Image = "https://i.imgur.com/QnE8Brd.jpeg" }
                
                );

                


            base.OnModelCreating(builder);
        }
    }
}
