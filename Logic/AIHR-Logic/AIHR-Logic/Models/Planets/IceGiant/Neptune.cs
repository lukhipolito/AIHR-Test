using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;
namespace AIHR_Logic.Models.Planets.IceGiants
{
    public sealed class Neptune : IceGiant
    {
        public Neptune()
        {
            this.Name = "Neptune";

            // Distance in KM
            this.DistanceFromSun = 4475879802;

            // Period in earth days
            this.OrbitalPeriod = 60155.65;

            //Neptune has 14 moons.
            //For the sake of avoiding repetition we are adding just the most notable and distinguishable one: Tritron
            this.Satellites = new List<Satellite>();

            var tritron = new Satellite { Name = "Tritron" };
            this.Satellites.Add(tritron);
        }
    }
}
