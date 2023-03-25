using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() {
            CarLot.numberOfCars++;
        }

        public Car(int year, string make, string model, string engineNoise, string honknoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honknoise;
            IsDriveable = isDriveable;
            CarLot.numberOfCars++;
        }


        public int Year { get; set; }
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
    }// end Car class
}//end namespace
