using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_Dev_Ops_TestingExercises
{
    public class Vehicle
    {
        public float maxSpeed { set; get; }
        public string manufacturer { set; get; }

        public Vehicle(string vManufacturer, float vMaxSpeed)
        {
            manufacturer = vManufacturer;
            maxSpeed = vMaxSpeed;
        }

        public int GetPercentageOfMaxSpeed(float pCurrentSpeed)
        {
            return Int32.Parse((pCurrentSpeed / maxSpeed * 100).ToString());
        }
    }
}
