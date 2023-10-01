using System.ComponentModel.DataAnnotations;

namespace u21657344_HW02.Models
{
    public class Location
    {
        [Key]
        public int locationId { get; set; }

        public string name { get; set; }
    }
}
