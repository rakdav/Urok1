using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok1
{
    internal class FlyBody:Body
    {
      

        private double High { get; set; }
        public FlyBody(double x1, double y1,double h) : base(x1, y1)
        {
            High = h;
        }
        private double PEnegy()
        {
            return Massa * 9.81 * High;
        }

        public new string Print()
        {
            return $"Ep={PEnegy():F2} Дж";
        }
    }
}
