using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany (DONE)

            //Create 3 classes called Car , Truck , & SUV (DONE)

            //In your IVehicle: (DONE)

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: (DONE)

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes (DONE)

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            IVehicle myCar = new Car 
            { 
                Make = "Toyota", 
                Model = "Camry", 
                Year = 2020, 
                Mileage = 15000.5, 
                Logo = "Toyota Logo", 
                Headquarters = "Toyota City, Japan", 
                HasTrunk = true, 
                TrunkCapacity = 500 
            }; 

            IVehicle myTruck = new Truck 
            { 
                Make = "Ford", 
                Model = "F-150", 
                Year = 2018, 
                Mileage = 40000, 
                Logo = "Ford Logo", 
                Headquarters = "Dearborn, Michigan", 
                PayloadCapacity = 3000, 
                HasFourWheelDrive = true 
            }; 
            
            IVehicle mySUV = new SUV 
            { 
                Make = "Honda", 
                Model = "CR-V", 
                Year = 2022, 
                Mileage = 10000, 
                Logo = "Honda Logo", 
                Headquarters = "Tokyo, Japan", 
                NumberOfSeats = 7, 
                HasAllWheelDrive = true 
            };

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface. (Done)
            //Implement the stubbed out method in the derived classes. (Done)
            //In the scope of them method, use string interpolation to display property values. (Done)
            myCar.DisplayDetails(); 
            myTruck.DisplayDetails(); 
            mySUV.DisplayDetails();
            Console.ReadKey();
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
        
    }
}
