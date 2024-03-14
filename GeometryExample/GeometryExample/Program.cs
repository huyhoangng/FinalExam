using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the dimenstions of the cylinder \n ");
            Console.Write("Enter the radius of the cylinder: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the cylinder: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Cylinder cylinder = new Cylinder(radius, height);
            cylinder.Process();
            Console.WriteLine(cylinder.Result());
        }
    }
}
