using static Csharpadvanced2024.Models.Location;

namespace Csharpadvanced2024.Models.DTOs.v2
{
    public class LocationDTOv2
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string LandLordAvatarUrl { get; set; }
        public float Price { get; set; }
        public LocationType Type { get; set; }
    }
}
