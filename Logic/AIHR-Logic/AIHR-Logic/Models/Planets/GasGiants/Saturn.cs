using AIHR_Logic.Interfaces;
using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;

namespace AIHR_Logic.Models.Planets.GasGiants
{
    public sealed class Saturn : GasGiant, IHasSatelliteMoon
    {
        public Saturn()
        {
            this.Name = "Saturn";

            // Distance in KM
            this.DistanceFromSun = 1482631855;

            // Period in earth days
            this.OrbitalPeriod = 10749.25;

            //Saturn has more than 80 moons.
            //For the sake of avoiding repetition we are adding just the most notable and distinguishable one: Titan

            this.Satellites = new List<Satellite>();

            var titan = new Satellite { Name = "Titan" };
            this.Satellites.Add(titan);
        }

        public IList<Satellite> Satellites { get; set; }
    }
}
