using System.Collections.Generic;

namespace AIHR_Logic.Models
{
    public sealed class SolarSystem
    {
        public abstract class Star
        {
            public string Name { get; set; }
        }

        public abstract class Planet
        {
            public string Name { get; set; }
            public IList<Satellite> Satellites { get; set; }
        }

        public abstract class DwarfPlanet
        {
            public string Name { get; set; }
            public IList<Satellite> Satellites { get; set; }
        }

        public abstract class TerrestrialPlanet : Planet
        {

        }

        public abstract class GasGiant : Planet
        {

        }

        public abstract class IceGiant : Planet 
        {

        }

        public sealed class Satellite
        {
            public string Name { get; set; }
        }
    }
}
