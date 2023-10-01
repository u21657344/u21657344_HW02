// ... existing using directives ...

using Microsoft.EntityFrameworkCore;
using u21657344_HW02.Models;
using u21657344_HW02.Models.Data;
using System.Linq;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
EnsureDbCreatedAndSeeded(app);

app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

void EnsureDbCreatedAndSeeded(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();

    if (!context.Users.Any())
    {
        var users = new List<User>
{
    new User
    {
        FirstName = "John",
        LastName = "Doe",
        PhoneNumber = "+1234567890"
    },
    new User
    {
        FirstName = "Jane",
        LastName = "Smith",
        PhoneNumber = "+0987654321"
    },
    new User
    {
        FirstName = "Alice",
        LastName = "Johnson",
        PhoneNumber = "+1123456789"
    },
    new User
    {
        FirstName = "Bob",
        LastName = "Brown",
        PhoneNumber = "+1098765432"
    },
    new User
    {
        FirstName = "Charlie",
        LastName = "Davis",
        PhoneNumber = "+1212345678"
    },
    new User
    {
        FirstName = "Diana",
        LastName = "Evans",
        PhoneNumber = "+1209876543"
    },
    new User
    {
        FirstName = "Evan",
        LastName = "Foster",
        PhoneNumber = "+1312345678"
    },
    new User
    {
        FirstName = "Faith",
        LastName = "Green",
        PhoneNumber = "+1309876543"
    },
    new User
    {
        FirstName = "George",
        LastName = "Harris",
        PhoneNumber = "+1412345678"
    },
    new User
    {
        FirstName = "Hannah",
        LastName = "Irwin",
        PhoneNumber = "+1409876543"
    },
    new User
    {
        FirstName = "Ian",
        LastName = "Jackson",
        PhoneNumber = "+1512345678"
    },
    new User
    {
        FirstName = "Julia",
        LastName = "Klein",
        PhoneNumber = "+1509876543"
    },
    new User
    {
        FirstName = "Kevin",
        LastName = "Lewis",
        PhoneNumber = "+1612345678"
    },
    new User
    {
        FirstName = "Linda",
        LastName = "Martin",
        PhoneNumber = "+1609876543"
    },
    new User
    {
        FirstName = "Mike",
        LastName = "Nelson",
        PhoneNumber = "+1712345678"
    }
};
        context.Users.AddRange(users);
        context.SaveChanges();

        if (!context.Pets.Any())
        {
            var pets = new List<Pet>
    {
             new Pet  
             {
                Name = "Buddy",
                Type = "Dog",
                Breed = "Golden Retriever",
                Location = "New York",
                Age = 3,
                Weight = 35.5,
                Gender = "Male",
                PetStory = "A friendly dog rescued from the streets, looking for a loving home.",
                Status = "Available",
                ImagePath = "path_to_image_of_Buddy",
                UserId = 1
             },
                new Pet
                {
                    Name = "Whiskers",
                    Type = "Cat",
                    Breed = "Siamese",
                    Location = "Los Angeles",
                    Age = 5,
                    Weight = 9.2,
                    Gender = "Female",
                    PetStory = "Whiskers was given up by her previous owner. She's a little shy but warms up quickly.",
                    Status = "Available",
                    ImagePath = "path_to_image_of_Whiskers",
                    UserId = 2
                },
                 new Pet
                {
                        Name = "Shadow",
                        Type = "Dog",
                        Breed = "Golden Retriever",
                        Location = "New York",
                        Age = 3,
                        Weight = 70.5,
                        Gender = "Male",
                        PetStory = "Shadow was found wandering the streets of New York. He's very friendly and loves children. He'd make a great family pet.",
                        Status = "Available",
                        ImagePath = "path_to_image_of_Shadow",
                        UserId = 3
                },
                  new Pet
                {
                   Name = "Misty",
                    Type = "Bird",
                    Breed = "Parrot",
                    Location = "Miami",
                    Age = 2,
                    Weight = 0.8, // Birds are typically light, measured in grams or a fraction of a kilogram
                    Gender = "Female",
                    PetStory = "Misty's previous owner could no longer care for her due to allergies. She's vocal, bright, and enjoys singing along to tunes.",
                    Status = "Available",
                    ImagePath = "path_to_image_of_Misty",
                    UserId = 4
                },
                   new Pet
                {
                        Name = "Rusty",
                        Type = "Dog",
                        Breed = "Golden Retriever",
                        Location = "Chicago",
                        Age = 3,
                        Weight = 32.5,
                        Gender = "Male",
                        PetStory = "Rusty loves playing fetch and has boundless energy. He was found as a stray, and he's looking for a forever home.",
                        Status = "Available",
                        ImagePath = "path_to_image_of_Rusty",
                        UserId = 5
                },
                    new Pet
                    {
                        Name = "Bubbles",
                        Type = "Fish",
                        Breed = "Goldfish",
                        Location = "New York",
                        Age = 1,
                        Weight = 0.05,
                        Gender = "Female",
                        PetStory = "Bubbles is a delightful fish with bright orange scales. She was given up when her previous owner moved.",
                        Status = "Available",
                        ImagePath = "path_to_image_of_Bubbles",
                        UserId = 6
                },
                     new Pet
                {
                    Name = "Fluffy",
                    Type = "Rabbit",
                    Breed = "Holland Lop",
                    Location = "Dallas",
                    Age = 2,
                    Weight = 2.8,
                    Gender = "Male",
                    PetStory = "Fluffy is a gentle rabbit who loves hopping around. His previous family had allergies, so he's searching for a new home.",
                    Status = "Available",
                    ImagePath = "path_to_image_of_Fluffy",
                    UserId = 7
                },
                      new Pet
                {
                        Name = "Daisy",
                        Type = "Hamster",
                        Breed = "Syrian",
                        Location = "San Francisco",
                        Age = 1,
                        Weight = 0.2,
                        Gender = "Female",
                        PetStory = "Daisy is a curious hamster who enjoys her exercise wheel. Her previous family is relocating and can't take her along.",
                        Status = "Available",
                        ImagePath = "path_to_image_of_Daisy",
                        UserId = 8
                },
                       new Pet
                       {
                                   Name = "Leo",
                    Type = "Cat",
                    Breed = "Maine Coon",
                    Location = "Miami",
                    Age = 6,
                    Weight = 16.2,
                    Gender = "Male",
                    PetStory = "Leo is a majestic Maine Coon with a loving personality. He loves to lounge around and be pampered.",
                    Status = "Available",
                    ImagePath = "path_to_image_of_Leo",
                    UserId = 9
                },
                        new Pet
                {
                                       Name = "Coco",
                        Type = "Parrot",
                        Breed = "Macaw",
                        Location = "Boston",
                        Age = 10,
                        Weight = 2.1,
                        Gender = "Female",
                        PetStory = "Coco has a vibrant personality and loves to mimic sounds. She's looking for an experienced bird handler.",
                        Status = "Available",
                        ImagePath = "path_to_image_of_Coco",
                        UserId = 10
                },
                         new Pet
                {
                                           Name = "Rocket",
                            Type = "Dog",
                            Breed = "Husky",
                            Location = "Denver",
                            Age = 2,
                            Weight = 35.4,
                            Gender = "Male",
                            PetStory = "Rocket is an energetic Husky who loves snowy weather. He needs an active family that can keep up with his energy.",
                            Status = "Available",
                            ImagePath = "path_to_image_of_Rocket",
                            UserId = 11
                },
                          new Pet
                {

                            Name = "Luna",
                            Type = "Cat",
                            Breed = "Sphynx",
                            Location = "Seattle",
                            Age = 3,
                            Weight = 8.3,
                            Gender = "Female",
                            PetStory = "Luna has a mysterious aura around her. She's a hairless cat and loves being wrapped in warm blankets.",
                            Status = "Available",
                            ImagePath = "path_to_image_of_Luna",
                            UserId = 12
                },
                           new Pet
                {
                                Name = "Spike",
                                Type = "Reptile",
                                Breed = "Iguana",
                                Location = "Phoenix",
                                Age = 5,
                                Weight = 10.5,
                                Gender = "Male",
                                PetStory = "Spike enjoys sunbathing and munching on leafy greens. He needs a spacious terrarium and some climbing structures.",
                                Status = "Available",
                                ImagePath = "path_to_image_of_Spike",
                                UserId = 13
                            },
                            new Pet
                {
                    Name = "Nemo",
                                Type = "Fish",
                                Breed = "Clownfish",
                                Location = "San Diego",
                                Age = 2,
                                Weight = 0.1,
                                Gender = "Male",
                                PetStory = "Nemo is a playful clownfish who loves hiding in anemones. He's looking for a well-maintained aquarium.",
                                Status = "Available",
                                ImagePath = "path_to_image_of_Nemo",
                                UserId = 14
                },
                             new Pet
                {
                                                 Name = "Dobby",
                                Type = "Rabbit",
                                Breed = "Netherland Dwarf",
                                Location = "Las Vegas",
                                Age = 1,
                                Weight = 2.3,
                                Gender = "Male",
                                PetStory = "Dobby has big ears and an even bigger heart. He loves to nibble on carrots and play hide and seek.",
                                Status = "Available",
                                ImagePath = "path_to_image_of_Dobby",
                                UserId = 15
                }



    };

            context.Pets.AddRange(pets);
            context.SaveChanges();
        }


    };


}
