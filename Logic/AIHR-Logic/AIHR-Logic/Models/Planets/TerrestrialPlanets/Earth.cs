using AIHR_Logic.Interfaces;
using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;

namespace AIHR_Logic.Models.Planets.TerrestrialPlanets
{
    public sealed class Earth : TerrestrialPlanet, ICanSustainLife, IHasSatelliteMoon, ICanBeTerraformed
    {
        public Earth()
        {
            this.Name = "Earth";

            // Distance in KM
            this.DistanceFromSun = 147683504;

            // Period in earth days
            this.OrbitalPeriod = 365.25;

            this.Satellites = new List<Satellite>();
            var moon = new Satellite { Name = "Moon" };
            this.Satellites.Add(moon);
        }

        public IList<Satellite> Satellites { get; set; }
    }
}
