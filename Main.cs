using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using ZombieGamemode.Vehicle;
using ZombieGamemode.Weapons;

namespace ZombieGamemode
{
    public class Main : BaseScript
    {
        public Main()
        {
            EventHandlers["playerSpawned"] += new Action<Vector3>(playerSpawned);

            API.RegisterCommand("giveweapon", new Action<int, List<object>, string>((src, args, raw) =>
            {
                var Weapon = new Weapons.Weapons();
                Weapon.Give(API.GetHashKey(args[0].ToString()), Int32.Parse(args[1].ToString()));
            }), false);
        }

        private void playerSpawned([FromSource] Vector3 coords)
        {
            var Vehicle = new Vehicle.Vehicle();
            Vector3 PlayerPos = Game.PlayerPed.Position;
            Vehicle.CreateVehicle("adder", PlayerPos, 50.0f);
        }
    }
}
