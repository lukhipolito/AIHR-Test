namespace AIHR_Logic.Models
{
    public abstract class CelestialBody
    {
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public double DistanceFromSun { get; set; }
        public double OrbitalPeriod { get; set; }
        public double Mass { get; set; }
    }
}
