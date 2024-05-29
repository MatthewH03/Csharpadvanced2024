using System.Reflection;

namespace Csharpadvanced2024.Models.DTOs
{
    public class LocationDTO
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public List<string> ImageUrls { get; set; }
        public string LandLordUrl { get; set; }
    }
}
