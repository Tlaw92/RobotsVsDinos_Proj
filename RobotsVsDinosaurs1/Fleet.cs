using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs1
{
    class Fleet
    {
        // I need a list to store my robots


        //Member Variables (Has a)
        public List<Robot> robots;

        //Constructors (initial values)
        public Fleet()
        {
            robots = new List<Robot>();
        }


        //Member Methods (Can do)
        public void AddRobotsToList()
        {
            Weapon lazerWeapon = new Weapon("Lazer", 50);
          
            Weapon blastWeapon = new Weapon("blast", 50);
            Weapon fireWeapon = new Weapon("flame", 50)
;
            Robot Bot1 = new Robot("Destroyer", 100, 100, fireWeapon);
            RobotStatlist(Bot1);
            Robot Bot2 = new Robot("Zapper", 100, 100, lazerWeapon);
            RobotStatlist(Bot2);
            Robot Bot3 = new Robot("Ben", 100, 100, blastWeapon);
            RobotStatlist(Bot3);

            robots.Add(Bot1);
            robots.Add(Bot2);
            robots.Add(Bot3);
     
            public void RobotStatlist(Robot robotStats)
        {
            Console.WriteLine(robotStats.name + " " + robotStats.health + " " + robotStats.powerLevel + " " + robotStats.weapon);
        }

    }
}
