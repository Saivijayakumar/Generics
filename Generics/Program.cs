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
            string maxValue = finding.MaxStringValue("sai", "vijaya", "kumar");
            Console.WriteLine("The maximum string is : {0} ",maxValue);
            Console.ReadLine();
        }
    }
}
