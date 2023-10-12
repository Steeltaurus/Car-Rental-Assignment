using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Customer : IPerson
{
    public string SocialSecurityNumber { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }

    public Customer(string socialSecurityNumber, string firstName, string lastName) =>
        (SocialSecurityNumber, FirstName, LastName) = 
        (socialSecurityNumber, firstName, lastName);
}