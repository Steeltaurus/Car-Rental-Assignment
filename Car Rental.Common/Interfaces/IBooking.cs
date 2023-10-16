using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public int Id { get; init; }
    public string RegistrationNumber { get; init; }
    public string Customer { get; init; }
    public int OdometerRented { get; init; }
    public int OdometerReturned { get; }
    public DateOnly DateRented { get; init; }
    public DateOnly DateReturned { get; }
    public double Cost { get; }
    public BookingStatuses Status { get; }

    public void ReturnVehicle(IVehicle vehicle, int odometer, DateOnly date);
}
