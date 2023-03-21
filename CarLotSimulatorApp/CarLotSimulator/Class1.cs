using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() {
        }
        public string Name { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }

        public void makeEngineNoise (string EngineNoise)
        {
            Console.WriteLine($"{EngineNoise}");
        }

        public void makeHonkNoise(string HonkNoise)
        {
            Console.WriteLine($"{HonkNoise}");
        }
    }
}
