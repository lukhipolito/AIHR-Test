using System.Collections.Generic;
using static AIHR_Logic.Models.SolarSystem;

namespace AIHR_Logic.Interfaces
{
    public interface IHasSatelliteMoon
    {
        public IList<Satellite> Satellites { get; set; }
    }
}
