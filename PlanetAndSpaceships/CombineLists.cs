using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetAndSpaceships
{
    class CombineLists
    {
        public void CombinePlanetLists(List<string> planets, List<string> otherPlanets)
        {
            planets.AddRange(otherPlanets);
        }
    }
}
