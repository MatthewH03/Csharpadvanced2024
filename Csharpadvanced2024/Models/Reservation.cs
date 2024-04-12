namespace Csharpadvanced2024.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CustomerId { get; set;}
        public Customer Customer { get; set;}
        public float Discount { get; set;}
    }
}
