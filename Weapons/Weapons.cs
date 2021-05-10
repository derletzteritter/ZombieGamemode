using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace ZombieGamemode.Weapons
{
    class Weapons : BaseScript
    {
        public Weapons()
        {
            Debug.WriteLine("Weapons class started");
        }

        public void Give(WeaponHash weapon, int ammoCount) 
        { 
            Game.PlayerPed.Weapons.Give(weapon, ammoCount, false, true);
        }

        public void GiveAttachment()
        {
            var weapon = Game.PlayerPed.Weapons.Current;
            weapon.Components.GetLuxuryFinishComponent(); // for testing
        }
    }
}
