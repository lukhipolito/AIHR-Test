using AIHR_Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AIHR_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            static List<CelestialBody> OrderedCelestialBodies() => SolarSystem.GetAllCelestialBodies().OrderBy(x => x.OrbitalPeriod).ToList();

            var celestialBodies = ((Func<List<CelestialBody>>)OrderedCelestialBodies).Invoke();

            Console.WriteLine("Hello World!");
        }
    }
}
