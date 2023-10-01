namespace u21657344_HW02.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; } // Consider using Enums or separate tables
        public string Breed { get; set; } // Consider using a lookup table
        public string Location { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Gender { get; set; } // Consider using Enums
        public string PetStory { get; set; }
        public string Status { get; set; } // Available/Adopted
        public string ImagePath { get; set; } // If storing as file paths, or byte[] if using Base64
        public int UserId { get; set; } // Foreign key
        public User User { get; set; } // Navigation property
                                       //... other properties as needed
    }
}
