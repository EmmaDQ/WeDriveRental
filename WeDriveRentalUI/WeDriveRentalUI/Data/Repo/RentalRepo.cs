using Shared;

namespace Logic
{
    public class RentalRepo : IRentalRepo
    {
        public void AddBooking(BookingModel booking)
        {
            throw new NotImplementedException();
        }

        public void DeleteBooking(BookingModel booking)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookingModel>> GetAllBookingsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<CarModel>> GetAllCarsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BookingModel> GetBookingByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void UpdateBooking(BookingModel booking)
        {
            throw new NotImplementedException();
        }
    }
}
