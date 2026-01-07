namespace TentantAPI.Entities
{
    public class Profile
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public int Age { get; set; }
        public decimal BudgetMin { get; set; }
        public decimal BudgetMax { get; set; }
        public string Location { get; set; } = null!;
        public string Bio { get; set; } = null!;

        public User User { get; set; } = null!;
    }
}