using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_Dev_Ops_TestingExercises
{
    class Bus : MotorVehicle
    {
        int maxNumPassengers;
        int numCurrentPassengers;

        public Bus(int pMaxPassengers, string pManufacturer, float pMaxSpeed,
                        int pMaxFuel, int pCurrentFuel, float pLitresPerKM)
                        : base(pManufacturer, pMaxSpeed, pMaxFuel, pCurrentFuel, pLitresPerKM)
        {
            maxNumPassengers = pMaxPassengers;
            numCurrentPassengers = 0;
        }

        public void EmbarkPassenger()
        {
            if (numCurrentPassengers < maxNumPassengers)
            {
                numCurrentPassengers++;
            }
            else
            {
                throw new Exception("Bus Is Full");
            }
        }

        public void DisembarkPassenger()
        {
            if (numCurrentPassengers > 0)
            {
                numCurrentPassengers--;
            }
            else
            {
                throw new Exception("There are No passengers left on the bus");
            }
        }
    }
}
