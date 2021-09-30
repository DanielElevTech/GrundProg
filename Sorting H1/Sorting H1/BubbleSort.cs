using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_H1
{
    public static class BubbleSort
    {
        public static void BubbleList(List<int> sort)
        {
                int temp;
                for (int a = 0; a <= sort.Count - 2; a++)
                {
                    for (int i = 0; i <= sort.Count - 2; i++)
                    {
                        if (sort[i] > sort[i + 1])
                        {
                            temp = sort[i + 1];
                            sort[i + 1] = sort[i];
                            sort[i] = temp;
                        }
                    }
                }
                foreach (int p in sort)
                    Console.Write(p + " ");
                Console.Read();
            
        }
    
    }
}
