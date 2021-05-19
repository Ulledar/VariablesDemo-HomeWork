using System;
using static System.Console;

namespace VariablesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Start()
            {
                Write("About which language do you want to know information? 1 - English, 2 - Spanish, 3 - Ukrainian ");
                string line = ReadLine();
                byte languageValue;
                if (!byte.TryParse(line, out languageValue) || languageValue > 3 || languageValue < 1)
                {
                    WriteLine("Please follow the instructions and try again");
                    Start();
                }
            }

            Write("About which language do you want to know information? 1 - English, 2 - Spanish, 3 - Ukrainian ");
            string line = ReadLine();
            byte languageValue;
            if (!byte.TryParse(line, out languageValue) || languageValue > 3 || languageValue < 1)
            {
                WriteLine("Please follow the instructions and try again");
                Start();
            }
            if (languageValue <= 3 && languageValue >= 1)
            {
                WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
                WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
                WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");
            }
        }
        public enum Language : byte
        {
            English = 1,
            Spanish = 2,
            Ukrainian = 3
        }
    }
}
