using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs1
{
    class Weapon
    {

        //Member Variables (Has a)
        public string weaponType;
        public int attackPower;


        //Constructors (initial values)
        public Weapon(string weaponType, int attackPower)
        {
            this.weaponType = weaponType;
            this.attackPower = attackPower;

        }
    }
}
