using System;
using System.Collections.Generic;

namespace PlanetAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };

            var addJupAndSat = new AddJupAndSat();
            var combineLists = new CombineLists();
            var completeSolarSystem = new CompleteSolarSystem();
            var rockyPlanets = new RockyPlanets();

            addJupAndSat.AddPlanets(planetList);
            combineLists.CombinePlanetLists(planetList, lastTwoPlanets);
            completeSolarSystem.AddEarthVenusPluto(planetList);
            rockyPlanets.ExtractRockyPlanets(planetList);

            foreach(string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.ReadLine();
        }
    }
}
