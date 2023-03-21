using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here is where I add a new instance of the CarLot class to the Main method.
            // It is called lot, which contains the property of a list
            var lot = new CarLot();
            
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and "l to the console

            var toyota = new Car();
            

            toyota.Make = "Toyota";
            toyota.Model = "Highlander";
            toyota.Year = 2013;
            toyota.EngineNoise = "Vroooooooooommmmmyyyyyyyyyy!";
            toyota.HonkNoise = "Honk! Honk!";
            toyota.IsDriveable = true;

            //Below, I am adding the new instance of Car (toyota) to the lot list
           lot.Cars.Add(toyota);


            Car jeep = new Car()
            {
                Year = 2013,
                Make = "Jeep",
                Model = "Cherokee",
                EngineNoise = "Verm. Splat. Verm. Splat",
                HonkNoise = "HOOOOOOOOONK!",
                IsDriveable = false
            };
            
            //Below, I am adding the new instance of Car (jeep) to the lot list
            lot.Cars.Add(jeep);

            Car mazda = new Car(2015, "Mazda", "Genesis", "Vrrrrrrrrrrrrrwalla", "Dum Dum Dum, dobedobdobedoooo", false);

            //Below, I am adding the new instance of Car (Mazda) to the lot list
            lot.Cars.Add(mazda);
                

            //Below, I am calling the two class methods for the three instanciated objects  
            toyota.makeEngineNoise(toyota.EngineNoise);
            toyota.makeHonkNoise(toyota.HonkNoise);

            jeep.makeEngineNoise(jeep.EngineNoise);
            jeep.makeHonkNoise(jeep.HonkNoise);

            mazda.makeEngineNoise(mazda.EngineNoise);
            mazda.makeHonkNoise(mazda.HonkNoise);

            foreach(var vehicle in lot.Cars)
            {
                Console.WriteLine($"Year:{vehicle.Year} Make:{vehicle.Make} Model:{vehicle.Model}");
            }

           





        }// End main method
    }
}
