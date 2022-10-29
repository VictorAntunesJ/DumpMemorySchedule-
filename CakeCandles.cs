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

class BirthdayCakeCandles
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */
    public static List<Aux> Add(List<Aux> ls, int item)
    {
        for (int i = 0; i < ls.Count; i++)
        {
            if (ls[i].vlr == item)
            {
                ls[i].qtd++;
                i = ls.Count;
                return ls;
            }
        }
        Aux temp = new Aux();
        temp.vlr = item;
        temp.qtd = 1;
        ls.Add(temp);
        return ls;
    }


    public static int rum(List<int> candles)
    {


        // List<Aux> ls = new List<Aux>();
        // for (int i = 0; i < candles.Count; i++)
        // {
        //     Add(ls, candles[i]);
        //     string str = string.Concat(i.ToString(), "-", candles[i].ToString(), "-", candles.Contains(candles[i]).ToString());
        //     Console.WriteLine(str);
        //     candles.GroupBy(n=> n.);
        // }
        // int retorno = ls.Max(p => p.qtd);
        // return retorno;

        int[] lsOrdenada = candles.OrderBy(p => p).ToArray();
        int tamanhoVetor = candles.Count;
        int controle = 0;
        int temp = 0;
        int max = 0;

        for (int i = 0; i < tamanhoVetor; i++)
        {

            if (lsOrdenada[i] != temp)
            {

                if (controle > 0 && controle > max)
                {
                    max = controle + 1;
                }
                temp = lsOrdenada[i];
                controle = 0;
            }
            else
            {
                controle++;
                if (i == tamanhoVetor - 1 && controle > 0 && controle > max)
                {
                    max = controle + 1;
                }
            }

        }
        return max;
    }

}

public class Aux
{
    public int vlr { get; set; }
    public int qtd { get; set; }

}