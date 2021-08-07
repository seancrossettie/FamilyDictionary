using System;
using System.Collections.Generic;

namespace Family_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Caroline" }, { "age", "23" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Julie" }, { "age", "53" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "John" }, { "age", "54" } });

            foreach(var member in myFamily)
            {
                    Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
            }
        }
    }
}
