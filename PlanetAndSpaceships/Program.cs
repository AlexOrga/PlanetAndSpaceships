using System;
using System.Collections.Generic;

namespace PlanetAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            var addJupAndSat = new AddJupAndSat();

            addJupAndSat.AddPlanets(planetList);

            foreach(string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.ReadLine();
        }
    }
}
