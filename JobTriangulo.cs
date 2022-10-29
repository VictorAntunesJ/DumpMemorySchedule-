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


public class Result
{

    private static double CalcularAreaTriangulo(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        return Math.Abs((x1 * (y2 - y3) +
                        x2 * (y3 - y1) +
                        x3 * (y1 - y2)) / 2.0);
    }

    private static bool testarPonto(int x1, int y1, int x2, int y2, int x3, int y3, int x, int y)
    {

        double A = CalcularAreaTriangulo(x1, y1, x2, y2, x3, y3);
        double A1 = CalcularAreaTriangulo(x, y, x2, y2, x3, y3);
        double A2 = CalcularAreaTriangulo(x1, y1, x, y, x3, y3);
        double A3 = CalcularAreaTriangulo(x1, y1, x2, y2, x, y);

        return (A == A1 + A2 + A3);
    }

    public static int pointsBelong(int x1, int y1, int x2, int y2, int x3, int y3, int xp, int yp, int xq, int yq)
    {

        bool p = false;
        bool q = false;
        bool a = CalcularAreaTriangulo(x1, y1, x2, y2, x3, y3) > 0;

        if (a == false)
        {
            return 0;
        }

        p = testarPonto(x1, y1, x2, y2, x3, y3, xp, yp);
        q = testarPonto(x1, y1, x2, y2, x3, y3, xq, yq);

        if (p && !q)
        {
            return 1;
        }
        if (!p && q)
        {
            return 2;
        }
        if (p && q)
        {
            return 3;
        }
        if (!p && !q)
        {
            return 4;
        }
        return -1;
    }

}

