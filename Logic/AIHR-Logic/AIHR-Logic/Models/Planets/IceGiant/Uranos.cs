using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;

namespace AIHR_Logic.Models.Planets.IceGiants
{
    public sealed  class Uranus : IceGiant
    {
        public Uranus()
        {
            //Uranus has 27 moons but not a single one or a group that is more notable than the others.
            //That's why we are not adding them, but the property is initialized to indicate there is at least one satellite in this planet's orbit.

            this.Satellites = new List<Satellite>();
        }
    }
}
