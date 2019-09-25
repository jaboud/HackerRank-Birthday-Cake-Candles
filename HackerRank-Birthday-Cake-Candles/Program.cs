using System;
using System.IO;
using System.Linq;

namespace HackerRank_Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            static int BirthdayCakeCandles(int[] ar)
            {
                //To find the biggest element within in the array, we use the First() function from System.Linq which goes through each element
                int max = ar.First();
            }

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
