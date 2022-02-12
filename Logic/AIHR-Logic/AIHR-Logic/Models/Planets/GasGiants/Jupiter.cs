using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;
namespace AIHR_Logic.Models.Planets.GasGiants
{
    public sealed class Jupiter : GasGiant
    {
        public Jupiter()
        {
            this.Name = "Jupiter";

            // Distance in KM
            this.DistanceFromSun = 745625585;

            // Period in earth days
            this.OrbitalPeriod = 4328.9;

            //Jupiter has 80 moons.
            //For the sake of avoiding repetition we are adding just the four biggest, a group known as Galilean Moons.

            this.Satellites = new List<Satellite>();
            var io = new Satellite { Name = "Io" };
            this.Satellites.Add(io);

            var europa = new Satellite { Name = "Europa" };
            this.Satellites.Add(europa);

            var ganymede = new Satellite { Name = "Ganymede" };
            this.Satellites.Add(ganymede);

            var callisto = new Satellite { Name = "Callisto" };
            this.Satellites.Add(callisto);
        }
    }
}
