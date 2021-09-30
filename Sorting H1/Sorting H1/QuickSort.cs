using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_H1
{
    public static class QuickSort
    {
        /*
         public static void QuickList(List<int> list)
         { 
             if(list.Count <= 1)
             {
                 Console.WriteLine("This list cannot be sorted");
             }

             int pivotPoint = list.Count / 2;
             int pivotValue = list[pivotPoint];
             List<int> left = new List<int>();
             List<int> right = new List<int>();

             for(int i=0; i<list.Count; i++)
             {
                 if (i == pivotPoint) continue;
             }


         }
        */


        public static List<int> QuickList(List<int> sort)
        {
            if (sort.Count <= 1) return sort;
            int pivotPosition = sort.Count / 2;
            int pivotValue = sort[pivotPosition];
            sort.RemoveAt(pivotPosition);
            List<int> smaller = new List<int>();
            List<int> greater = new List<int>();
            foreach (int item in sort)
            {
                if (item < pivotValue)
                {
                    smaller.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            List<int> sorted = QuickList(smaller);
            sorted.Add(pivotValue);
            sorted.AddRange(QuickList(greater));
            foreach (int p in sort)
                Console.Write(p + " ");
            return sorted;
        }
    }
}
