using System.ComponentModel.DataAnnotations;

namespace u21657344_HW02.Models
{
    public class Breed
    {
        [Key]
        public int breedId { get; set; }

        public string breedName { get; set; }
    }
}
