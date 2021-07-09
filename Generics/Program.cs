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
            Console.WriteLine(" Creating Generics Method and Class  \n");

            int[] intArray = { 84, 234, 42, 45, 33 };
            float[] floatArray = { 13.2f, 4.4f, 19.32f, 54.5f};
            string[] stringArray = { "Sai", "Vijaya", "Kumar", "Apple", "Fan" ,"zoo"};

            FindingMaximum<int> findForInt = new FindingMaximum<int>(intArray);
            FindingMaximum<float> findForFloat = new FindingMaximum<float>(floatArray);
            FindingMaximum<string> findForString = new FindingMaximum<string>(stringArray);

            findForInt.PrintMax();
            findForFloat.PrintMax();
            findForString.PrintMax();
            Console.ReadLine();
        }
    }
}
