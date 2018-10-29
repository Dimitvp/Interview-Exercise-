using System;

namespace TotalValuesEvenNumbers
{
    class TotalValuesEvenNumbers
    {
        //Given an array of ints, write a C# method to total all the values that are even numbers.
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 3, 5, 1, 5, 6, 3, 8, 9 };

            Console.WriteLine(TotalValues(arr));
        }

        static int TotalValues(int[] arr)
        {
            var totalSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    totalSum += arr[i];
                }
            }

            return totalSum;
        }

        //Better solutions for interview
        //static long TotalAllEvenNumbers(int[] intArray)
        //{
        //    return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
        //}
        //or:

        //static long TotalAllEvenNumbers(int[] intArray)
        //{
        //    return (from i in intArray where i % 2 == 0 select (long)i).Sum();
        //}
        //Here are the key things to look for in the answer:

        //    1.Does the candidate take advantage of the C# language constructs which make a one-liner solution possible (i.e., rather than             employing a more lengthy solution which contains a loop, conditional statement, and accumulator)?
        //    2.Does the candidate consider the possibility of overflow.For example, an implementation such as return intArray.Where(i => i % 2 == 0).Sum() (regardless of the return type of the function) might be an “obvious” one-line solution, but the probability of overflow here is high.While the approach used in the answers above of converting to long doesn’t eliminate the possibility, it makes it a highly unlikely that an overflow exception will occur.Note that, if the candidate asks about the expected size of the array and the magnitude of its members, he or she is obviously considering this overflow issue, which is part of what we’re looking to ascertain.
    }
}
