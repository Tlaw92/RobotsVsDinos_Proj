using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Herd herd1 = new Herd();
            //herd1.AddDinosToList();
       
            

            Battlefield battlefieldStart = new Battlefield();
            battlefieldStart.Game();

            Console.ReadLine();
        }
    }
}
