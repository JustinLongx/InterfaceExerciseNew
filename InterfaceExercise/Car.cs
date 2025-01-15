using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        //Specific to Car
        public bool HasTrunk { get; set; }
        public int TrunkCapacity { get; set; }
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
            Console.WriteLine($"Car Details:");
            Console.WriteLine($"------------");
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nMileage: {Mileage}\nHas Trunk: {HasTrunk}\nTrunk Capacity: {TrunkCapacity} liters\nLogo: {Logo}\nHeadquarters: {Headquarters}\n");
        }
    }
}
