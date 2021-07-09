using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class  FindingMaximum<T> where T :IComparable
    {
        public T[] array;
        //Parameter constructor 
        public FindingMaximum(T[] array)
        {
            this.array = array;
        }
        //It returns Sorted array
        public T[] Sort()
        {
            Array.Sort(array);
            return array;
        }
        //It returns the last element in an array
        public T FindingMaxValue()
        {
            T[] sorted = this.Sort();
            return sorted[sorted.Length -1];
        }

    }
}
