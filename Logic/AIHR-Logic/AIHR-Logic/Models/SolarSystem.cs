using AIHR_Logic.Models.Stars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AIHR_Logic.Models
{
    public static class SolarSystem
    {
        public static List<CelestialBody> GetAllCelestialBodies()
        {
            var celestialBodies = new List<CelestialBody>();
            foreach (Type type in 
                Assembly.GetAssembly(typeof(CelestialBody)).GetTypes()
                .Where(x => x.IsClass 
                        && x != typeof(Sun)
                        && !x.IsAbstract 
                        && x.IsSubclassOf(typeof(CelestialBody))))
            {
                celestialBodies.Add((CelestialBody)Activator.CreateInstance(type));
            }

            return celestialBodies;
        }


        #region Main celestial bodies categories
        public abstract class Star : CelestialBody
        {

        }

        public abstract class Planet : CelestialBody
        {

        }

        public abstract class DwarfPlanet : CelestialBody
        {

        }
        #endregion


        #region Planet categories
        public abstract class TerrestrialPlanet : Planet
        {

        }

        public abstract class GasGiant : Planet
        {

        }

        public abstract class IceGiant : Planet 
        {

        }
        #endregion


        #region Satellites
        public sealed class Satellite
        {
            public string Name { get; set; }
        }
        #endregion
    }
}
