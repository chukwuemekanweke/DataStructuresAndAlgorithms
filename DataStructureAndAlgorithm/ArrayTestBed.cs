using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm
{
    [Serializable]
    public class ArrayTestBed:ICloneable
    {
        public int[] arr;
        public int upper;
        public int numOfElements;

        public ArrayTestBed(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numOfElements = 0;
        }

        public void Insert(int item)
        {
            arr[numOfElements] = item;
            numOfElements++;
        }

        public void DispayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }

        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }
            numOfElements = 0;

        }

        public virtual object Clone()
        {
            return this.CloneObject();

        }
    }
}
