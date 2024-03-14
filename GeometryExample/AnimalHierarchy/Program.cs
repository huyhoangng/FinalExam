using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Lion's details:");
            Console.Write("Enter name: ");
            string lionName = Console.ReadLine();
            Console.Write("Enter weight (kg): ");
            double lionWeight = Convert.ToDouble(Console.ReadLine());

            Lion lion = new Lion(lionWeight, lionName);

            Console.WriteLine("\nEnter Tiger's details:");
            Console.Write("Enter name: ");
            string tigerName = Console.ReadLine();
            Console.Write("Enter weight (kg): ");
            double tigerWeight = Convert.ToDouble(Console.ReadLine());

            Tiger tiger = new Tiger(tigerWeight, tigerName);

            Console.WriteLine();
            lion.Show();
            Console.WriteLine();
            tiger.Show();
        }
    }
}
