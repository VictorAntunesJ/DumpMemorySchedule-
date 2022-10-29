using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace exercises
{
    public class ResultJobTest
    {

        public static List<int> cardinalitySort(List<int> nums)
        {
            List<int> lstRenorno = new List<int>();
            List<ItemCardinalidade> list = new List<ItemCardinalidade>();
            ItemCardinalidade obj = new ItemCardinalidade();
            foreach (int num in nums)
            {
                obj = new ItemCardinalidade();
                obj.numD = num;
                obj.numB = Convert.ToString(num, 2);
                for (int i = 0; i < obj.numB.Length; i++)
                {
                    //string temp =
                    if (obj.numB.Substring(i, 1).Equals("1"))
                    {
                        obj.cardinalidade++;
                    }
                }
                list.Add(obj);

            }
            var lst = from itens in list orderby itens.cardinalidade, itens.numD select itens;
            foreach (ItemCardinalidade it in lst)
            {
                lstRenorno.Add(it.numD);
            }

            return lstRenorno;

        }


        public static void staircase(int n)
        {
            for (int x = 1; x <= n; x++)
            {
                for (int y = 1; y <= n; y++)
                {
                    if ((y + x) <= n)
                    {
                        Console.Write(" ");
                    }
                    else if (y == n)
                    {
                        Console.WriteLine("#");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
            }
        }

        public static List<string> sortRoman(List<string> names)
        {

            List<string> Retorno = new List<string>();
            List<ItemRomno> ls = new List<ItemRomno>();
            ItemRomno it = new ItemRomno();
            foreach (string nm in names)
            {
                it = new ItemRomno();
                it.name = nm.Split(' ')[0].Trim();
                it.numR = nm.Split(' ')[1].Trim();
                it.numD = romanoToInt(it.numR);

                ls.Add(it);
            }
            //IEnumerable<ItemRomno> query = ls.OrderByDescending(it => it.name);
            var lst = from itens in ls orderby itens.name, itens.numD select itens;
            foreach (ItemRomno item in lst)
            {
                Retorno.Add(item.name + ' ' + item.numR);
            }
            return Retorno;
        }



        public static int romanoToInt(string str1)
        {
            var num = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (i > 0 && find_value(str1[i]) > find_value(str1[i - 1]))
                {
                    num += find_value(str1[i]) - find_value(str1[i - 1]) * 2;
                }
                else
                {
                    num += find_value(str1[i]);
                }
            }

            return num;
        }

        public static int find_value(char chr)
        {
            switch (chr)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }


    public class ItemRomno
    {
        public string? name { get; set; }
        public string? numR { get; set; }
        public int numD { get; set; }
    }


    public class ItemCardinalidade
    {
        public int numD { get; set; }
        public string? numB { get; set; }
        public int cardinalidade { get; set; }
    }


}






