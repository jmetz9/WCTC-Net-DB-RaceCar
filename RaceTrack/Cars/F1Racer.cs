using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class F1Racer : RaceCar
    { 
        public F1Racer()
        {
            Name = "F1Racer";
            TopSpeed = 500;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} revs up!");
        }

        public override void Brake(){
            Console.WriteLine($"The {Name} skids to a halt!");
        }

        public void Boast(){
            Console.WriteLine($"The driver of the {Name} starts showing off for the crowd");
        }
    }
}
