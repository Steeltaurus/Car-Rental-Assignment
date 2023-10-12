using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Motorcycle : IVehicle
{
    public string RegistrationNumber { get; init; }
    public string Make { get; init; }
    public int Odometer { get; set; }
    public double CostPerKm { get; init; }
    public int CostPerDay { get; init; }
    public VehicleTypes VehicleType { get; init; }
    public VehicleStatuses Status { get; set; }

    public Motorcycle(string registrationNumber, string make, int odometer, double costPerKm,
        VehicleTypes vehicleType)
    {
        RegistrationNumber = registrationNumber;
        Make = make;
        Odometer = odometer;
        CostPerKm = costPerKm;
        VehicleType = vehicleType;
        Status = VehicleStatuses.Available;
        CostPerDay = 50;
    }
}
