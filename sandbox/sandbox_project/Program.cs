using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class D
{
    static void Main()
    {

        int [] d = R(5);
        Array.Sort(d);
        Console.WriteLine("Values: " + string.Join(", ", d));
        int s = C(d);
        Console.WriteLine("Total: " + s);
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.
    }

    static int [] R(int n)
    {
        Random r = new Random();
        int [] d = new int [n];
        for (int i = 0; i < n; i++)
        {
            d[i] = r.Next(1, 7);
        }
        return d;
    }

    static int C(int [] d)
    {
        int s = 0;
        Dictionary<int, int> c = new Dictionary<int, int>();
        foreach (int x  in d)
        {
            if (c.ContainsKey(x))
            {
                c[x]++;
            }
            else
            {
                c[x] = 1;
            }
        }
        foreach (int v in c.Values)
        {
            switch (v)
            {
                case 2:
                    s = s + 10;
                    break;
                case 3:
                    s = s + 20;
                    break;
                case 4:
                    s = s + 30;
                    break;
                case 5: 
                    s = s + 5;
                    break;
            }
        }

        return s;
    }
}