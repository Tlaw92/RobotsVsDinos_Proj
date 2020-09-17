using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs1
{
    class Dinosaur

    {
        //Member Variables (Has a)
        public string name;
        public int health;
        public int powerLevel;
        public string attackType;
        public int attackPower;

        //Constructors (initial values)

        public Dinosaur(string name, int health, int powerLevel, string attackType, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.attackType = attackType;
            this.attackPower = attackPower;

        }

        //Member Methods (Can do)
        //attack

        public void Attack(Robot robotToAttack)
        {
            robotToAttack.health -= attackPower;
        }

    }
}
