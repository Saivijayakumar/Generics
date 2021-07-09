using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        /// <summary>
        /// -------->Welcome to Generics<---------
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            FindingMaximum finding = new FindingMaximum();
            int maxvalue = finding.MaxValue(10,21,2);
            Console.WriteLine($"The maximum value of three numbers is {maxvalue} ");
            Console.ReadLine();
        }
    }
}
