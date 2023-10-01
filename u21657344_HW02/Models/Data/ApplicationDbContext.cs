using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace u21657344_HW02.Models.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet properties for your models
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Breed> Breeds{ get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<petType> Types { get; set; }






        // ... Add more DbSet properties for other models if necessary.
    }
}
