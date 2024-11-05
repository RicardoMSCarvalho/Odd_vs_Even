using System;
using System.Collections.Generic;
public class OddAndEven
{
    public static void OddOrEven(int[] vet)
    {
        Dictionary<string, List<int>> dt1 = new Dictionary<string, List<int>>();

        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] % 2 == 0)
            {
                if (!dt1.ContainsKey("Even"))
                {
                    dt1["Even"] = new List<int>();
                }
                dt1["Even"].Add(vet[i]);
            }
            else
            {
                if (!dt1.ContainsKey("Odd"))
                {
                    dt1["Odd"] = new List<int>();
                }
                dt1["Odd"].Add(vet[i]);
            }
        }

        foreach (KeyValuePair<string, List<int>> kvp in dt1)
        {
            Console.WriteLine($"{kvp.Key}:");
            foreach (var item in kvp.Value)
            {
                Console.WriteLine($"Nº {item}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        OddAndEven.OddOrEven(numbers);
    }
}
