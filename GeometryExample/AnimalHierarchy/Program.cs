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
            Lion lion = new Lion(100, "tiger");
            Tiger tiger = new Tiger(200, "lion");

            lion.Show();
            Console.WriteLine();
            tiger.Show();
        }
    }
}
