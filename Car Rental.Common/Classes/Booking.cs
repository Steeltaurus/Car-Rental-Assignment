using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Booking : IBooking
{
    public int Id { get; init; }
    public string RegistrationNumber { get; init; }
    public string Customer { get; init; }
    public int OdometerRented { get; init; }
    public int OdometerReturned { get; private set; }
    public DateOnly DateRented { get; init; }
    public DateOnly DateReturned { get; private set; }
    public double Cost { get; private set; }
    public BookingStatuses Status { get; private set; }

    public Booking(int id, string registrationNumber, string customer, int odometerRented,
        DateOnly dateRented)
    {
        Id = id;
        RegistrationNumber = registrationNumber;
        Customer = customer;
        OdometerRented = odometerRented;
        DateRented = dateRented;
        Status = BookingStatuses.Open;
    }

    public void ReturnVehicle(IVehicle vehicle, int odometer, DateOnly date)
    {
        OdometerReturned = odometer;
        DateReturned = date;
        Status = BookingStatuses.Closed;
        Cost = vehicle.CostPerDay * ((this.DateReturned.DayNumber - this.DateRented.DayNumber) + 1)
             + vehicle.CostPerKm * (this.OdometerReturned - this.OdometerRented);
    }
}
