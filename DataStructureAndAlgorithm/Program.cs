using System;
using System.Threading;

namespace DataStructureAndAlgorithm
{
    class Program
    {

        static ISort selectionSortAlgorithm { get; set; }
        static ISort bubbleSortAlgorithm { get; set; }
        static ISort insertionSortAlgorithm { get; set; }


        static void Main(string[] args)
        {
            selectionSortAlgorithm = new SelectionSort(false);
            bubbleSortAlgorithm = new BubbleSort(false);
            insertionSortAlgorithm = new InsertionSort(false);

            Console.WriteLine("Hello World!");

            ArrayTestBed numbersTestBed = new ArrayTestBed(10000);
            Random rnd = new Random(100);
            for (int i=0; i<=9999; i++)
            {
                numbersTestBed.Insert((int)(rnd.NextDouble()*10000));
            }




            Sort(bubbleSortAlgorithm, numbersTestBed.CloneObject(), numbersTestBed.CloneObject(), "Bubble");
            Sort(selectionSortAlgorithm, numbersTestBed.CloneObject(), numbersTestBed.CloneObject(), "Selection");
            Sort(insertionSortAlgorithm, numbersTestBed.CloneObject(), numbersTestBed.CloneObject(), "Insertion");


            //Metrics metric = new Metrics("Bubble Sort");

            //var result  = SortAlgorithm.Sort(numbersTestBed);

            //metric.Dispose();
            //metric = new Metrics("Reverse Bubble Sort");

            //var result2 = SortAlgorithm.ReverseSort(clonedTestArrayBed);
            //metric.Dispose();


            //numbersTestBed.arr = result;
            //numbersTestBed.DispayElements();

            //numbersTestBed.arr = result2;
            //numbersTestBed.DispayElements();



            Console.ReadLine();
        }


        public static void Sort(ISort SortAlgorithm, ArrayTestBed origArrayTestBed, ArrayTestBed clonedArrayTestBed, string algorithmTitle)
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

    }
}
