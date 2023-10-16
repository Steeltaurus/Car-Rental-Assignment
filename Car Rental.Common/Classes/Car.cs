using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string RegistrationNumber { get; init; }
    public string Make { get; init; }
    public int Odometer { get; private set;  }
    public double CostPerKm { get; init; }
    public int CostPerDay { get; init; }
    public VehicleTypes VehicleType { get; init; }
    public VehicleStatuses Status { get; private set; }

    public Car(string registrationNumber, string make, int odometer, double costPerKm,
        VehicleTypes vehicleType, VehicleStatuses status = VehicleStatuses.Available)
    {
        RegistrationNumber = registrationNumber;
        Make = make;
        Odometer = odometer;
        CostPerKm = costPerKm;
        VehicleType = vehicleType;
        Status = status;

        switch (vehicleType)
        {
            case VehicleTypes.Sedan:
                CostPerDay = 100;
                break;
            case VehicleTypes.Combi:
                CostPerDay = 200;
                break;
            case VehicleTypes.Van:
                CostPerDay = 300;
                break;
        }
    }
}
