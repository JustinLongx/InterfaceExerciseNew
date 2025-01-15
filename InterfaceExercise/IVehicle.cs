using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double Mileage { get; set; }

        void DisplayDetails();

    }
}
