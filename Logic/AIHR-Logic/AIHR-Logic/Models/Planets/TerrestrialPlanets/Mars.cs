using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;
namespace AIHR_Logic.Models.Planets.TerrestrialPlanets
{
    public sealed class Mars : TerrestrialPlanet 
    {
        public Mars()
        {
            this.Satellites = new List<Satellite>();
            var phobos = new Satellite { Name = "Phobos" };
            this.Satellites.Add(phobos);

            var deimos = new Satellite { Name = "Deimos" };
            this.Satellites.Add(deimos);
        }
    }
}
