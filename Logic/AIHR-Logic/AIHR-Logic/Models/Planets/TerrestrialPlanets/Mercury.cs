using static AIHR_Logic.Models.SolarSystem;

namespace AIHR_Logic.Models.Planets.TerrestrialPlanets
{
    public sealed class Mercury : TerrestrialPlanet
    {
        public Mercury()
        {
            this.Name = "Mercury";

            // Distance in KM
            this.DistanceFromSun = 64506529;

            // Period in earth days
            this.OrbitalPeriod = 88;
        }
    }
}
