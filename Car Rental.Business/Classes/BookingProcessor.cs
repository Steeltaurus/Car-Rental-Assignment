﻿using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    private readonly IData _db;

    public BookingProcessor(IData db) => _db = db;

    public IEnumerable<IPerson> GetCustomers()
    {
        return _db.GetPersons();
    }
    public IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default)
    {
        return _db.GetVehicles();
    }
    public IEnumerable<IBooking> GetBookings()
    {
        var booking = _db.GetBookings().Single(b => b.RegistrationNumber.Equals("JKL012"));
        var vehicle = _db.GetVehicles().Single(b => b.RegistrationNumber.Equals("JKL012"));
        booking.ReturnVehicle(vehicle, 5000, new DateOnly(2023, 9, 9));
        
        return _db.GetBookings();
    }
}
