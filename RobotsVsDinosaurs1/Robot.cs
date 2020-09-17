using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs1
{
    class Robot
        //Robot should have a name, health points, power level, and a second class called Weapon that has a weapon type, and attack power
    {
        //Member Variables (Has a)

        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;

        //Constructors (initial values)

        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
        }

        //Member Methods (Can do)
        //Attack
        public void Attack(Dinosaur dinoToAttack)
        {
            dinoToAttack.health -= weapon.attackPower;
        }
    }
}
