using static AIHR_Logic.Models.SolarSystem;

namespace AIHR_Logic.Models.Planets.TerrestrialPlanets
{
    public sealed class Venus : TerrestrialPlanet
    {
        public Venus()
        {
            this.Name = "Venus";

            // Distance in KM
            this.DistanceFromSun = 107596781;

            // Period in earth days
            this.OrbitalPeriod = 225;
        }
    }
}
