using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;

namespace AIHR_Logic.Models.Planets.TerrestrialPlanets
{
    public sealed class Earth : TerrestrialPlanet
    {
        public Earth()
        {
            this.Satellites = new List<Satellite>();
            var moon = new Satellite { Name = "Moon" };
            this.Satellites.Add(moon);
        }
    }
}
