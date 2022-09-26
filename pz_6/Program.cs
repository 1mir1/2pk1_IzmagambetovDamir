using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n <= 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            int a = 3;
            bool x = false;
            if (Math.Log(n) % Math.Log(a) == 0)
                x = true;
            else
                x = false;
            Console.WriteLine(x);
        }
    }
}
