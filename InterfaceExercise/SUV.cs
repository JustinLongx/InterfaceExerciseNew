using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        // Specific to SUV
        public int NumberOfSeats { get; set; }
        public bool HasAllWheelDrive { get; set; }
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
            Console.WriteLine($"SUV Details:");
            Console.WriteLine($"------------");
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nMileage: {Mileage}\nNumber of Seats: {NumberOfSeats}\nAll-Wheel Drive: {HasAllWheelDrive}\nLogo: {Logo}\nHeadquarters: {Headquarters}\n");
        }
    }
}
