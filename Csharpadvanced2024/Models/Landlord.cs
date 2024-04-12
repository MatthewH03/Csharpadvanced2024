namespace Csharpadvanced2024.Models
{
    public class Landlord
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public ICollection<Image> Avatar { get; set; }
        public ICollection<Location> Locations { get; set; }
    }
}
