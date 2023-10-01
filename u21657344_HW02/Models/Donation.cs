namespace u21657344_HW02.Models
{
    public class Donation
    {
        public int DonationId { get; set; }
        public double Amount { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
