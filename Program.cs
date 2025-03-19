// See https://aka.ms/new-console-template for more information

using System;

class PemrosesData
{
    public static T DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic max = (dynamic)a;
        if (max < b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        return max;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Nilai terbesar dari 1.0, 3.0, 2.2 adalah " + PemrosesData.DapatkanNilaiTerbesar(1.0, 3.0, 2.2));
    }
}
