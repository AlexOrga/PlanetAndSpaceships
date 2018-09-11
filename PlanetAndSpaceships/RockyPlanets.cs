using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetAndSpaceships
{
    class RockyPlanets
    {
        public List<string> rockyPlanets { get; set; } = new List<string>();

        public void ExtractRockyPlanets(List<string> planets)
        {
            planets.Remove("Pluto");
            rockyPlanets = planets.GetRange(0, 4);
            foreach(string planet in rockyPlanets)
            {
                Console.WriteLine($"rockyPlanet: {planet}");
            }
        }
    }
}
