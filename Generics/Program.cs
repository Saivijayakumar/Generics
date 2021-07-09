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
            float maxValue = finding.MaxFloatValue(10.3f, 20.6f, 20.5f);
            Console.WriteLine("The maximum value of three numbers is {0} ",maxValue);
            Console.ReadLine();
        }
    }
}
