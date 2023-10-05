using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class car:Program
    {
       public void carSpecifications()
        {
            Console.WriteLine("color : blue");
            Console.WriteLine("Model : SupraMK4");
            Console.WriteLine("Price : 50000000");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car sp = new car();
            sp.carSpecifications();
            Console.ReadLine();
        }
    }
}
