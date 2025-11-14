namespace BeeBuzz.Data.Entities
{
    public class Organization
    {
        public int Id { get; set; }
        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
        public ICollection<Beehive> Beehives { get; set; } = new List<Beehive>();
    }
}
