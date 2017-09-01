using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_Dev_Ops_TestingExercises
{
    public class MotorVehicle : Vehicle
    {
        public int maxFuel { set; get; }
        public int currentFuel { set; get; }
        public float litresPerKm { set; get; }

        public MotorVehicle(string pManufacturer, float pMaxSpeed, int pMaxFuel, 
                            int pCurrentFuel, double pLitresPerKM) 
                            : base(pManufacturer, pMaxSpeed)
        {
            maxFuel = pMaxFuel;
            currentFuel = pCurrentFuel;
            litresPerKm = Convert.ToSingle(pLitresPerKM);
        }

        // fills the motor vehicle from its current fuel level to its max fuel level 
        // and rteurns the number of litres put into the vehicle during refueling
        public int Refuel()
        {
            int vAmountAdded = maxFuel - currentFuel;
            currentFuel = maxFuel;
            return vAmountAdded;
        }

        // decreases the amount of current fuel by the # kms travelled * litres per KM.
        public void Travel(int pNumKMTravelled)
        {
            int fuelRequired = (Int32)(litresPerKm * pNumKMTravelled);

            if (currentFuel >= fuelRequired)
            {
                currentFuel -= fuelRequired;
            }
            else
            {
                currentFuel = 0;
                throw new Exception("You ran out of fuel numb nuts");
            }
        }

    }
}
