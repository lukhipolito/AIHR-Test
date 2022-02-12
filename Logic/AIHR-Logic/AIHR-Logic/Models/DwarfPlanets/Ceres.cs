using static AIHR_Logic.Models.SolarSystem;
namespace AIHR_Logic.Models.DwarfPlanets
{
    public sealed class Ceres : DwarfPlanet
    {
        public Ceres()
        {
            this.Name = "Ceres";

            // Distance in KM
            this.DistanceFromSun = 401577205;

            // Period in earth days
            this.OrbitalPeriod = 1679;
        }
    }
}
