using System;
using System.Linq;
using System.Collections.Generic;
namespace exercises
{

    public class ResultiniMaxSum
    {

        public static void rum()
        {
            int[] num = { 256741038, 623958417, 467905213, 714532089, 938071625 };
            ResultiniMaxSum.miniMaxSum(num.ToList());
        }

        public static void miniMaxSum(List<int> arr)
        {

            int sum = 0;
            foreach (int valorItem in arr)
            {
                sum = sum + valorItem;
            }
            double totalG = sum;

            double sumCorrente = 0;
            double max = 0;
            double min = totalG;
            foreach (int valorItem in arr)
            {
                sumCorrente = totalG - valorItem;
                if (sumCorrente > max)
                {
                    max = sumCorrente;
                }
                if (sumCorrente < min)
                {
                    min = sumCorrente;
                }
            }
            Console.Write(min);
            Console.Write(" ");
            Console.Write(max);

        }

        public static void miniMaxSum2(List<long> arr0)
        {
            long[] arr2 = { 254961783, 604179258, 462517083, 967304281, 860273491 };
            long[] arr = { 69082435, 210437958, 673982045, 375809214, 380564127 };
            long m = 0;
            long n = 99999999;
            long sum = arr.Sum();
            long temp = 0;
            foreach (long i in arr)
            {
                temp = sum - i;
                if (temp > m)
                {
                    m = temp;
                }
                if (temp < n)
                {
                    n = temp;
                }
            }
            Console.Write(string.Format("{0} {1}", n, m));
        }


    }

}