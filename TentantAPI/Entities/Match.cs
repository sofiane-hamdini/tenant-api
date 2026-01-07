namespace TentantAPI.Entities
{
    public class Match
    {
        public Guid Id { get; set; }
        public Guid RequesterUserId { get; set; }
        public Guid TargetUserId { get; set; }

        public MatchStatus Status { get; set; }
    }
}
