using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] strings = { "twizzy", "flawless", "yeat", "tonka", "lyfe" };

        var result = strings.Select(s => s.Length % 2 != 0 ? s.First() : s.Last())
                            .OrderByDescending(c => c)
                            .ToArray();

        Console.WriteLine(new string(result));
    }
}

