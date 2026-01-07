namespace TentantAPI.Entities
{
    public class Listing
    {
        public Guid Id { get; set; }
        public Guid OwnerUserId { get; set; }

        public decimal Rent { get; set; }
        public string Location { get; set; } = null!;
        public DateTime MoveInDate { get; set; } 
        public string Description { get; set; } = null!;

        public User Owner { get; set; } = null!;
    }
}