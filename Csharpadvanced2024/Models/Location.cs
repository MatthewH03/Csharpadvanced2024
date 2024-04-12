using static System.Net.Mime.MediaTypeNames;

namespace Csharpadvanced2024.Models
{
    public class Location
    {
        [Flags]
        public enum FeaturesEnum
        {
            Smoking = 1,
            PetsAllowed = 2,
            Wifi = 4,
            TV = 8,
            Bath = 16,
            Breakfast = 32
        }

        public enum LocationType
        {
            Appartment,
            Cottage,
            Chalet,
            Room,
            Hotel,
            House
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public LocationType Type { get; set; }
        public int Rooms { get; set; }
        public int NumberOfGuests { get; set; }
        public FeaturesEnum Features { get; set; }
        public ICollection<Image> Images { get; set; }
        public float PricePerDay { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Landlord> Landlord { get; set; }

    }
}
