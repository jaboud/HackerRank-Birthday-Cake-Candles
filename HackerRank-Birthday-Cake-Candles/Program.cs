using System;
using System.IO;

namespace HackerRank_Birthday_Cake_Candles
{
    class Program
    {
        static void Main(string[] args)
        {
            static int BirthdayCakeCandles(int[] ar)
            {

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
