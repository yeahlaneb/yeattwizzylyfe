using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Масив словників
        List<Dictionary<string, string>> dictionaries = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string>
            {
                {"key1", "value1"},
                {"key2", "value2"},
                {"key3", "value3"}
            },
            new Dictionary<string, string>
            {
                {"key1", "value4"},
                {"key2", "value5"},
                {"key3", "value6"}
            },
            new Dictionary<string, string>
            {
                {"key1", "value7"},
                {"key2", "value8"},
                {"key3", "value9"}
            }
        };

        // Пошук та виведення кількості знайдених результатів для кожного словника
        foreach (var dict in dictionaries)
        {
            Console.WriteLine($"Dlya slovnika:");
            int count = SearchByKey(dict, "key1");
            Console.WriteLine($"Kilkist znaydenix rezultativ: {count}\n");
        }

        // Збереження у JSON файл
        string json = JsonConvert.SerializeObject(dictionaries, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText("results.json", json);

        Console.WriteLine("Rezultatu zberezheny u faili results.json");
    }

    static int SearchByKey(Dictionary<string, string> dictionary, string key)
    {
        // Кількість знайдених результатів за ключем
        int count = dictionary.Count(kv => kv.Key == key);
        return count;
    }
}
