using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> countries = new MyDictionary<string, string>();
            
            countries.Add("tr", "Turkey");
            countries.Add("de", "Germany");
            countries.Add("nl", "Netherlands");
            countries.Add("az", "Azerbaijan");
            countries.Add("uk", "United Kingdom");

            for (int i = 0; i < countries.Item1.Length; i++)
            {
                Console.WriteLine( countries.Item1[i] + " : " + countries.Item2[i]);

            }
        }
    }
}
