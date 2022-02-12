﻿using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;
namespace AIHR_Logic.Models.DwarfPlanets
{
    public sealed class Pluto : DwarfPlanet
    {
        public Pluto()
        {
            this.Satellites = new List<Satellite>();

            var charron = new Satellite { Name = "Charron" };
            this.Satellites.Add(charron);

            var nix = new Satellite { Name = "Nix" };
            this.Satellites.Add(nix);

            var hydra = new Satellite { Name = "Hydra" };
            this.Satellites.Add(hydra);

            var kerberos = new Satellite { Name = "Cerberos" };
            this.Satellites.Add(kerberos);

            var styx = new Satellite { Name = "Styx" };
            this.Satellites.Add(styx);
        }
    }
}