namespace BeeBuzz.Data.Entities
{
    public class Beehive
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Deactivation { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}
