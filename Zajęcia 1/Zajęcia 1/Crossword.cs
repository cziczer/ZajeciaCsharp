using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia_1
{
    class Crossword
    {
        public static void Start()
        {
            string[][] jaggedArray = new string[3][];
            jaggedArray[0] = new string[5];
            jaggedArray[1] = new string[4];
            jaggedArray[2] = new string[1];

            for (int i = 0; i < jaggedArray[0].Length; i++)
            {
                Console.Write(" -");
            }
            Console.Write("\n");
            foreach (var row in jaggedArray)
            {
                //for (int i = 0; i < row.Length; i++)
                //{
                //    Console.Write($"|");
                //}

                foreach (var letter in row)
                {
                    if(letter == null)
                        Console.Write($"| ");
                    else
                        Console.Write($"|{letter}");
                }
                Console.Write("|");
                Console.Write("\n");
                for (int i = 0; i < row.Length; i++)
                {
                    Console.Write(" -");
                }
                Console.Write("\n");
            }
        }
    }
}
