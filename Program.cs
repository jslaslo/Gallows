using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Gallows
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] dictionary = File.ReadAllLines("WordsStockRus.txt");
            int numberWords = dictionary.Length;
            Random random = new Random();
            string Word = dictionary[random.Next(numberWords)];
            
                char[] symbol = new char[Word.Length];
                for (int i = 0; i < Word.Length; i++)
                {
                    symbol[i] = '_';
                }
            while (true)
            {
                Console.WriteLine(symbol);

                Console.WriteLine("Введите букву...");
                char intendedLetter = char.Parse(Console.ReadLine());

                for (int i = 0; i < Word.Length; i++)
                {
                    if (Word[i] == intendedLetter)
                    {
                        symbol[i] = Word[i];
                    }
                }
                
                
                Console.Clear();
            }           
            




        }
    }
}
