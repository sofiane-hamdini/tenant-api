using System.Runtime;

namespace TentantAPI.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public Profile? Profile { get; set; }
        public ICollection<Listing> Listings { get; set; } = new List<Listing>();
    }
}
