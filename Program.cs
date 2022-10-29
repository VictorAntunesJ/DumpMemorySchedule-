using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);


            //ResultiniMaxSum.rum();
            //int result = Result.pointsBelong(2, 2, 7, 2, 5, 4, 4, 3, 7, 4);
            //int result = Result.pointsBelong(3, 1, 7, 1, 5, 5, 1, 1, 4, 3);
            //int result = Result.pointsBelong(0, 0, 2, 0, 4, 0, 2, 0, 4, 0);
            // int[] vt = { 3, 2, 1, 3 };
            //int result = BirthdayCakeCandles.rum(vt.ToList());
            //Console.WriteLine(result);
            // string[] entrada = { "Hacker", "Rank" };
            // teste(entrada);
            // int[] a = { 3, 2, 3 };
            // int[] queries = { 0, 1, 2 };


            // int[] a = { 3, 4, 5 };
            // int[] queries = { 1, 2 };

            // List<int> result = circularArrayRotation(a.ToList(), 2, queries.ToList());
            // Console.WriteLine(String.Join("\n", result));

            ///Console.WriteLine(factorial(6));
            //Console.WriteLine(problema.kangaroo(2081, 8403, 9107, 8400));
            testeInheritance.run();


        }

        public static int factorial(int n)
        {
            // Console.WriteLine(n);
            if (n > 1)
            {
                return n * factorial(n - 1);
            }
            return n;

        }


        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {


            // int[] a = { 3, 4, 5 };
            // int[] queries = { 1, 2 };

            // List<int> result = circularArrayRotation(a.ToList(), 2, queries.ToList());
            // Console.WriteLine(String.Join("\n", result));



            List<int> aux = new List<int>();
            int limit = 0;
            if (k > a.Count)
            {
                k = k % a.Count;
            }

            limit = a.Count - k;

            Console.WriteLine(k);
            Console.WriteLine(limit);
            Console.WriteLine(a.Count);

            for (int i = limit; i < a.Count; i++)
            {
                Console.Write(i);
                Console.Write("-entrou 1 : ");
                Console.WriteLine(a[i]);
                aux.Add(a[i]);
            }
            for (int i = 0; i < limit; i++)
            {
                Console.Write(i);
                Console.Write("-entrou 2: ");
                Console.WriteLine(a[i]);
                aux.Add(a[i]);
            }
            Console.WriteLine(String.Join(",", a));
            Console.WriteLine(String.Join(",", aux));
            Console.WriteLine(String.Join(",", queries));

            Console.WriteLine("=======================================");
            List<int> retorno = new List<int>();
            foreach (int index in queries)
            {
                Console.WriteLine(index);
                if (index < aux.Count)
                {
                    retorno.Add(aux[index]);

                }
            }
            Console.WriteLine(String.Join(",", retorno));
            return retorno;

        }



        public static void teste(string[] args)
        {
            string[] entrada = { "Hacker", "Rank" };
            teste(entrada);
            string str1 = string.Empty;
            string str2 = string.Empty;
            int resto = 0;
            foreach (string item in args)
            {
                str1 = string.Empty;
                str2 = string.Empty;
                for (int i = 0; i < item.Length; i++)
                {
                    resto = (i % 2);
                    if (resto == 0)
                    {
                        str1 = str1 + item.Substring(i, 1);
                    }
                    else
                    {
                        str2 = str2 + item.Substring(i, 1);
                    }
                }
                Console.WriteLine(string.Concat(str1, " ", str2));
            }

        }


        public static void fizzBuzz(int n)
        {
            bool mult3 = false;
            bool mult5 = false;

            for (int i = 1; i <= n; i++)
            {
                mult3 = (i % 3 == 0);
                mult5 = (i % 5 == 0);
                if (mult3 && mult5)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (mult3)
                {
                    Console.WriteLine("Fizz");
                }
                else if (mult5)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }

    }
}






