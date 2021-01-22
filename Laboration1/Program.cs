using System;
using System.Collections.Generic;
using System.Numerics;

namespace Laboration1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
            och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
            siffror förekommer där emellan. */
            BigInteger sum = 0;
            List<string> startStr = new List<string>();
            List<string> matches = new List<string>();
            List<string> endStr = new List<string>();
            string inputStr = "29535123p48723487597645723645";
            for (int i = 0; i < inputStr.Length - 1; i++)
            {
                if (Char.IsDigit(inputStr[i]))
                {
                    for (int j = i + 1; j < inputStr.Length; j++)
                    {
                        if (Char.IsDigit(inputStr[j]))
                        {
                            if (inputStr[i] == inputStr[j])
                            {
                                startStr.Add(inputStr[0..i]);
                                matches.Add(inputStr[i..(j + 1)]);
                                endStr.Add(inputStr[(j + 1)..inputStr.Length]);
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i < matches.Count; i++)
            {
                Console.Write(startStr[i]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(matches[i]);
                Console.ResetColor();
                Console.WriteLine(endStr[i]);
            }
            foreach (var match in matches)
            {
                sum += BigInteger.Parse(match);
            }
            Console.WriteLine("\nTotal sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
