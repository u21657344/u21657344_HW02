using System.ComponentModel.DataAnnotations;

namespace u21657344_HW02.Models
{
    public class petType
    {
        [Key]
        public int petTypeId { get; set; }

        public string description { get; set; }
    }
}
