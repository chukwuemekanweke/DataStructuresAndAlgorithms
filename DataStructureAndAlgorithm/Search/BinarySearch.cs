using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm.Search
{
    public class BinarySearch
    {
        public int Search(int[] values, int searchItem)
        {
            int upperBound, lowerBound, mid;
            upperBound = values.Length - 1; ;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if (values[mid] == searchItem)
                    return mid;
                else if (searchItem < values[mid])
                    upperBound = mid - 1;
                else
                    lowerBound = mid + 1;
            }
            return -1;
        }

        public int RecursiveSearch(int[] values, int upperBound,int  lowerBound, int searchItem)
        {
            if (lowerBound > upperBound)
                return -1;

            int mid = (upperBound + lowerBound) / 2;
            if (values[mid] == searchItem)
            {
                return mid;
            }
            else if (searchItem > values[mid])
                return RecursiveSearch(values, upperBound, mid + 1, searchItem);
            else
                return RecursiveSearch(values, mid-1, lowerBound, searchItem);


            return -1;
        }
    }
}
