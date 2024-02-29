using Shared;

namespace Logic
{
    public interface IRentalRepo
    {
        public Task<List<BookingModel>> GetAllBookingsAsync();
        public Task<List<CarModel>> GetAllCarsAsync();
        public Task<BookingModel> GetBookingByUsername(string username);
        public void UpdateBooking(BookingModel booking);
        public void AddBooking(BookingModel booking);
        public void DeleteBooking(BookingModel booking);



    }
}
