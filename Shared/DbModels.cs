using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        public string ModelType { get; set; } = null!;
        public string ModelDescription { get; set; }
        public string ModelColor { get; set; }
        public string Image { get; set; }
        public bool IsBoked { get; set; }
        public DateTime DateTime { get; set; }
        public List<BookingModel> Bookings { get; set; }

    }

    public class BookingModel
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
        public List<CarModel> Cars { get; set; }


    }


}
