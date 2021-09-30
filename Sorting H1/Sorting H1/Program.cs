using System;
using System.Collections.Generic;

namespace Sorting_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            //formålet er at øve mig på forskelige sorteringsmetoder inden for programering. 
            //Quicksort: EN effektiv sorterings metode.
            //Bubble sort. En mere simpel men mindre effektiv metode.
            //Bogo, eller slowsort. en joke metode jeg gerne vil prøve at lære.

            List<int> sortThisList = new List<int>() { 19, 4, 15, 12, 9, 1, 8, 10, 20, 18, 14, 11, 5, 3, 13, 17, 2, 6, 7, 16 };
             bool tryAgain;


            Console.WriteLine("Choose which sorting metod to test");
            Console.WriteLine("Press 1 to choose bubblesort.\nPress 2 to choose quicksort.\nPress 3 to choose bogosort");
            
            do
            {
                string userNumber = Console.ReadLine();
                switch (userNumber)
                {
                    case "1":
                        BubbleSort.BubbleList(sortThisList);
                        tryAgain = false;
                        break;

                    case "2":
                        QuickSort.QuickList(sortThisList);
                        tryAgain = false;
                        break;

                    case "3":
                        BogoSort.BogoList(sortThisList);
                        tryAgain = false;
                        break;
                        
                    default:
                        Console.WriteLine("No valid input detected. Try again.");
                        tryAgain = true;
                        break;
                }
            } while (tryAgain == true);

            Console.ReadKey();
        }
    }
}
