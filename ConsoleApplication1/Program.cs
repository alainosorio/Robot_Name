using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Robot jhonn = new Robot();

            Robot anna = new Robot();

            if (anna.Name() == jhonn.Name())
            {
                anna = new Robot();
            }

            Console.WriteLine(jhonn.Name());

            Console.WriteLine(anna.Name());

            Console.ReadKey();
        }
    }
}
