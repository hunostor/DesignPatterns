using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new AdapterExample();
            example.Start();

            Console.ReadKey(true);
        }
    }
}
