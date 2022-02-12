using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;
namespace AIHR_Logic.Models.Planets.TerrestrialPlanets
{
    public sealed class Mars : TerrestrialPlanet 
    {
        public Mars()
        {
            this.Name = "Mars";

            // Distance in KM
            this.DistanceFromSun = 221564230;

            // Period in earth days
            this.OrbitalPeriod = 686.2;

            this.Satellites = new List<Satellite>();
            var phobos = new Satellite { Name = "Phobos" };
            this.Satellites.Add(phobos);

            var deimos = new Satellite { Name = "Deimos" };
            this.Satellites.Add(deimos);
        }
    }
}
