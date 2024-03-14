using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Cylinder
    {
        private double Radius { get; }
        private double Height { get; }
        private double BaseArea { get; set; }
        private double LateralArea { get; set; }
        private double TotalArea { get; set; }
        private double Volume { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public string Result()
        {
            return $"Base Area: {BaseArea}\n" +
                   $"Lateral Area: {LateralArea}\n" +
                   $"Total Area: {TotalArea}\n" +
                   $"Volume: {Volume}";
        }
    }
}
