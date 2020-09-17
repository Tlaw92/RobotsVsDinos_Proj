using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs1
{
    // I need a list to store my Dinosaurs
    class Herd
    {

        //Member Variables (Has a)
        //list of dinos
        public List<Dinosaur> dinosaurs;


        //Constructors (initial values)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
        }


        //Member Methods(Can do)
        public void AddDinosToList()
        {
            Dinosaur Dino1 = new Dinosaur("Raptor", 1000, 100, "Claw", 101);
            DinoStatlist(Dino1);
            Dinosaur Dino2 = new Dinosaur("Barney", 2000, 200, "Bite", 102);
            DinoStatlist(Dino2);
            Dinosaur Dino3 = new Dinosaur("Bill", 3000, 300, "Ram", 103);
            DinoStatlist(Dino3);

            dinosaurs.Add(Dino1);
            dinosaurs.Add(Dino2);
            dinosaurs.Add(Dino3);
        }

        public void DinoStatlist(Dinosaur dinoStats)
        {
            Console.WriteLine(dinoStats.name + " " + dinoStats.health + " " + dinoStats.powerLevel + " " + dinoStats.attackType + " " + dinoStats.attackPower);
        }


    }
}
