using System;
using System.IO;
using System.Linq;

namespace HackerRank_Birthday_Cake_Candles
{
    class Program
    {
        static int BirthdayCakeCandles(int[] ar)
        {
            //To find the biggest element within in the array, we use the First() function from System.Linq which goes through each element
            int max = ar.First();
            //To count each time we find the max value of an element. For example, 5 is the highest number in the array and appears 3 times, the count will be 3.
            int count = 1;

            for(int i = 1; i < ar.Length; i++)
            //for (int i = 0; i < ar.Length; i++)
            {
                //We check if the element in the array is greater than the current max element then we set the max to that new element we found and reset the count to 1
                //For example, our current element in our max is 3 and we find another another element in the array that is 5, we set the max to 5 and reset the count to 1
                if (ar[i] > max)
                {
                    max = ar[i];
                    count = 1;
                }
                //We check if the element in the array is equal to the current max element then we increment the count by 1.
                //For example, our current element in our max is 5 and we find another element in the array that is also 5, we increment the count by 1.
                else if (ar[i] == max)
                {
                    count++;
                }
            }

            return count;

        }
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = BirthdayCakeCandles(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
