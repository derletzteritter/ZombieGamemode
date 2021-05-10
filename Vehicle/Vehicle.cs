using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZombieGamemode.Vehicle
{
    class Vehicle : BaseScript
    {
        public Vehicle()
        {
            Debug.WriteLine("Vehicle class started");
        }

        public void CreateVehicle(Model model, Vector3 coords, float heading)
        {
            World.CreateVehicle(model, coords, heading);
        }
    }
}
