using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetAndSpaceships
{
    class CompleteSolarSystem
    {
        public void AddEarthVenusPluto(List<string> planets)
        {
            planets.Insert(1, "Venus");
            planets.Insert(2, "Earth");
            planets.Add("Pluto");
        }
    }
}
