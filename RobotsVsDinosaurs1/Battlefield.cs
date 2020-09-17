using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs1
{
    class Battlefield
    {
        //Member Variables (Has a)

            //Herd of Dinos
            //fleet of robots

        Fleet robotFleet = new Fleet();       
        Herd dinoHerd = new Herd();

        //Constructors (initial values)
        public Battlefield()
            //robot 
        {
            robotFleet.AddRobotsToList();
            dinoHerd.AddDinosToList();
        }

        //Member Methods (Can do)
            
            //robots attack dinos
            //dinos attack robots and win
            //start a battle

        public void Game()
        {
            RobotsAttack();
            DinosAttack();
        }
        public void RobotsAttack()
        {
            Console.WriteLine("The robots are attacking the Dinosaurs :( ");
            robotFleet.robots[0].Attack(dinoHerd.dinosaurs[0]);
            //Console.WriteLine("Destroyer attacked Raptor and now Raptor's health " + Herd.health);

            robotFleet.robots[1].Attack(dinoHerd.dinosaurs[1]);
            robotFleet.robots[2].Attack(dinoHerd.dinosaurs[2]);
        }

        public void DinosAttack()
        {
            Console.WriteLine("Now the Dinosaurs will attack");
            dinoHerd.dinosaurs[0].Attack(robotFleet.robots[0]);
            dinoHerd.dinosaurs[1].Attack(robotFleet.robots[1]);
            dinoHerd.dinosaurs[2].Attack(robotFleet.robots[2]);

        }
        public void StartBattle()
        {
            
        }

    }
}
