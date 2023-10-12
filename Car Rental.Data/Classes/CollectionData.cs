using Car_Rental.Common.Enums;
using Car_Rental.Data.Interfaces;
using Car_Rental.Common.Interfaces;
using Car_Rental.Common.Classes;

namespace Car_Rental.Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new();
    readonly List<IVehicle> _vehicles = new();
    readonly List<IBooking> _bookings = new();

    public CollectionData() => SeedData();

    public void SeedData()
    {
        _persons.Add(new Customer("12345","John", "Doe"));
        _persons.Add(new Customer("98765", "Jane", "Doe"));

        _vehicles.Add(new Car("ABC123", "Volvo", 10000, 1.0, VehicleTypes.Combi));
        _vehicles.Add(new Car("DEF456", "Saab", 20000, 1.0, VehicleTypes.Sedan));
        _vehicles.Add(new Car("GHI789", "Tesla", 1000, 3.0, VehicleTypes.Sedan));
        _vehicles.Add(new Car("JKL012", "Jeep", 5000, 1.5, VehicleTypes.Van));
        _vehicles.Add(new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle));

        _bookings.Add(new Booking(1, "GHI789", "Doe John (98765)", 1000, new DateOnly(2023, 9, 9)));
        _bookings.Add(new Booking(2, "JKL012", "Doe Jane (12345)", 5000, new DateOnly(2023, 9, 9)));
        
        _bookings.Single(b => b.RegistrationNumber.Equals("JKL012")).ReturnVehicle(5000, new DateOnly(2023, 9, 9), 300);
    }

    public IEnumerable<IPerson> GetPersons() => _persons;
    public IEnumerable<IBooking> GetBookings() => _bookings;
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
    {
        if (status == 0)
            return _vehicles;
        else
            return _vehicles.Where(v => v.Status.Equals(status));
    }
}