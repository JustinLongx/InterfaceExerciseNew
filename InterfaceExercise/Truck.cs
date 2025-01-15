using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        
        // Specific to Truck
        public double PayloadCapacity { get; set; } 
        public bool HasFourWheelDrive { get; set; }
        //IVehicle
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        //ICompany
        public string Logo { get; set; }
        public string Headquarters { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Truck Details:");
            Console.WriteLine($"------------");
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nMileage: {Mileage}\nPayload Capacity: {PayloadCapacity} kg\nFour-Wheel Drive: {HasFourWheelDrive}\nLogo: {Logo}\nHeadquarters: {Headquarters}\n");
        }
    }
}
