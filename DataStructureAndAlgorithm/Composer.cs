using DataStructureAndAlgorithm.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm
{
    public class Composer
    {

        static ISort selectionSortAlgorithm { get; set; }
        static ISort bubbleSortAlgorithm { get; set; }
        static ISort insertionSortAlgorithm { get; set; }

        public Composer()
        {

            selectionSortAlgorithm = new SelectionSort(false);
            bubbleSortAlgorithm = new BubbleSort(false);
            insertionSortAlgorithm = new InsertionSort(false);
        }

        public void ComposeSortingAlgo()
        {

            Console.WriteLine("Hello World!");

            ArrayTestBed numbersTestBed = new ArrayTestBed(10000);
            Random rnd = new Random(100);
            for (int i = 0; i <= 9999; i++)
            {
                numbersTestBed.Insert((int)(rnd.NextDouble() * 10000));
            }




            Sort(bubbleSortAlgorithm, numbersTestBed.CloneObject(), numbersTestBed.CloneObject(), "Bubble");
            Sort(selectionSortAlgorithm, numbersTestBed.CloneObject(), numbersTestBed.CloneObject(), "Selection");
            Sort(insertionSortAlgorithm, numbersTestBed.CloneObject(), numbersTestBed.CloneObject(), "Insertion");
        }

        private static void Sort(ISort SortAlgorithm, ArrayTestBed origArrayTestBed, ArrayTestBed clonedArrayTestBed, string algorithmTitle)
        {
            //origArrayTestBed.DispayElements();

            GC.Collect();
            Metrics metric = new Metrics($"{algorithmTitle} Sort");

            var result = SortAlgorithm.Sort(origArrayTestBed);


            metric.Dispose();
            GC.Collect();

            metric = new Metrics($"Reverse {algorithmTitle} Sort");

            var result2 = SortAlgorithm.ReverseSort(clonedArrayTestBed);

            metric.Dispose();


            origArrayTestBed.arr = result;
            clonedArrayTestBed.arr = result2;


            //origArrayTestBed.DispayElements();

            //clonedArrayTestBed.DispayElements();
            Console.WriteLine();

            Console.WriteLine("=======================================================================================================================================");
            Console.WriteLine();
        }



        public void ComposeSearch()
        {
            BinarySearch binSearch = new BinarySearch();
            ArrayTestBed numbersTestBed = new ArrayTestBed(10000);
            Random rnd = new Random(100);
            for (int i = 0; i <= 9999; i++)
            {
                numbersTestBed.Insert((int)(rnd.NextDouble() * 10));
            }




            var result = insertionSortAlgorithm.Sort(numbersTestBed);



            //numbersTestBed.DispayElements();

            GC.Collect();
            Metrics metric = new Metrics($"Binary Search ");
            var position =  binSearch.Search(numbersTestBed.arr, 2);
            metric.Dispose();

            GC.Collect();
            metric = new Metrics($"Recursive Binary Search ");
            var position2 = binSearch.RecursiveSearch(numbersTestBed.arr, numbersTestBed.arr.Length-1,0, 2);
            metric.Dispose();

            GC.Collect();
            metric = new Metrics($"Inbuilt C# Binary Search ");
            var position3 = Array.BinarySearch(numbersTestBed.arr, 2);
            metric.Dispose();

            if (position > -1 && position2>-1 && position3>-1)
            {
                Console.WriteLine("Found Item");

            }
            else
            {
                Console.WriteLine("Not in the array");
            }
        }




    }
}
