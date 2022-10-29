
using System;
using System.Linq;
using System.Collections.Generic;
namespace exercises
{

    public class problema
    {

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 < x2 && v1 <= v2)
            {
                return "NO-1";
            }
            else if (x2 < x1 && v2 <= v1)
            {
                return "NO-2";
            }

            long tempX = 0;
            long tempY = 0;
            for (int i = 1; i <= 1000; i++)
            {
                tempX = x1 + i * v1;
                tempY = x2 + i * v2;
                if (tempX == tempY)
                {
                    return "YES";
                }
            }
            return "NO-3";
        }
    }
}