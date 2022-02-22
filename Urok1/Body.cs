namespace Urok1
{
    public class Body
    {
        public double Massa { get; set; } = 0;
        public double Velocity { get; set; }

        public Body(double x1, double y1)
        {
           this.Massa= x1;
           this.Velocity = y1;
        }

        public double KEnergy()
        {
            return Massa * Velocity*Velocity/2;
        }

        public string Print()
        {
            return $"{KEnergy()}";
        }
    }
}