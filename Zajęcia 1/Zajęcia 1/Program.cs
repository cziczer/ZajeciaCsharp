using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;

namespace Zajęcia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ZMIENNE

            int intVar = 4;
            intVar = 5;
            double doubleVar = 31.2;
            float floatVar1 = 1.5F;
            float floatVar2 = (float)1.5;
            //float badFloat = 1.4;
            //double bardziej precyzyjny

            var variable1 = 1;
            var variable2 = 1.5;
            var variable3 = 1.5F;

            //int sum1 = intVar + doubleVar;
            var sum2 = intVar + doubleVar;
            var sum3 = doubleVar + floatVar1;
            var sum4 = floatVar1 + floatVar2;

            // STRINGI
            var str1 = "string 1";
            var str2 = "string 2";
            //Console.WriteLine(str2);

            //dynamic dynamicVar = "Siema";
            //Console.WriteLine(dynamicVar.GetType());
            //dynamicVar = 4;
            //Console.WriteLine(dynamicVar.GetType());

            //str2 = "Inny napis xD";
            //Console.WriteLine(str2);

            //str2 += "Koniec napisu";
            //Console.WriteLine(str2);

            //str2.Replace("i", "L");
            //Console.WriteLine(str2);

            //str2 = str2.Replace("i", "L");
            //Console.WriteLine(str2);

            //Console.WriteLine(str1 + str2);
            //Console.WriteLine("Napis {0}, {1}", str1, str2);
            //Console.WriteLine("Napis " + str1 + ", " + str2);
            //Console.WriteLine($"Napis {str1}\n {str2}");
            //Console.WriteLine($"Napis {str1}\\n {str2}");
            //Console.WriteLine(@$"Napis {str1}\n {str2}");

            //var addNumToString = intVar + str1;
            //Console.WriteLine(addNumToString);

            //var addNumToString2 = (intVar + doubleVar) + str1;
            //Console.WriteLine(addNumToString2);

            //var addNumToString3 = intVar + doubleVar + str1;
            //Console.WriteLine(addNumToString3);

            // CZY STRING RÓŻNI SIĘ OD ZWYKŁYCH ZMIENNY?

            // MOŻNA LEPIEJ?

            //StringBuilder sb = new StringBuilder("Ala ma kota");
            //Console.WriteLine(sb);

            //sb.Replace("a", "R");
            //Console.WriteLine(sb);

            ////sb += "Dodajemy dodatkowy napis";
            //sb.Append("Dodajemy dodatkowy napis");
            //Console.WriteLine(sb);

            // INSTRUKCJE WARUNKOWE

            //bool isStatementTrue = true;

            //if (isStatementTrue)
            //    Console.WriteLine("1 większe od 2");
            //else if (intVar == 4)
            //    Console.WriteLine("Nasza zmienna jest równa 4");
            //else
            //    Console.WriteLine("Coś innego");

            //SWITCH

            string player1 = "paper";
            string player2 = "scissors";

            //switch (player1, player2)
            //{
            //    case ("rock", "paper"):
            //        Console.WriteLine("rock is covered by paper. Paper wins.");
            //        break;
            //    case ("rock", "scissors"):
            //        Console.WriteLine("rock breaks scissors. Rock wins.");
            //        break;
            //    case ("paper", "rock"):
            //        Console.WriteLine("paper covers rock. Paper wins.");
            //        break;
            //    case ("paper", "scissors"):
            //    case ("scissors", "rock"):
            //        Console.WriteLine("No one wins :P");
            //        break;
            //    default:
            //        Console.WriteLine("No matching statement");
            //        break;
            //}

            //Console.WriteLine(RockPaperScissors(player1, player2));

            // TABLICE

            int[] arr = new int[4];
            arr[0] = 5;
            arr[1] = 2;

            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[3]); // nie przypisaliśmy wartości
            //Console.WriteLine(arr);

            int[] arr2 = { 1, 4, 6, 5, 12 };
            object[] arrObjects = { 1, 4, 6, 5, 12, "Ja jestem napisem" };
            //Console.WriteLine(arrObjects[3]);
            //Console.WriteLine(arrObjects[5]);

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            //Console.WriteLine(i); // i istnieje tylko w pętli

            //var iterator = 0;
            //while (iterator < arr2.Length)
            //{
            //    Console.WriteLine(arr2[iterator]);
            //    iterator++;
            //}


            //foreach (var item in arr2)
            //{
            //    //item += 2; // w foreach nie można edytować elementów
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(string.Join(" ", arrObjects));

            var words = new string[]
            {
                // index from start    index from end
                "The",      // 0                   ^9 
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1// Nie musimy używać arr.Length - 1 :D
            };

            //Console.WriteLine($"The last word is {words[^1]}");

            //var quickBrownFox = words[1..4];
            //Console.WriteLine(string.Join(" ", quickBrownFox));

            //var lazyDog = words[^2..^0];
            //Console.WriteLine(string.Join(" ", lazyDog));

            //var allWords = words[..];
            //Console.WriteLine(string.Join(" ", allWords));

            //var firstPhrase = words[..4];
            //Console.WriteLine(string.Join(" ", firstPhrase));

            //var lastPhrase = words[6..];
            //Console.WriteLine(string.Join(" ", lastPhrase));

            //int[,] arr3 = new int[3, 4];
            //int[,,] arr4 = new int[4, 1, 2];

            //int[,] arr5 =
            //{
            //    {1, 3, 5},
            //    {3, 1, 6}
            //};

            //foreach (var item in arr5) // iteruje po elementach, nie po wierszach
            //{
            //    Console.Write(item + " ");
            //}

            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[5];
            //jaggedArray[1] = new int[1];
            //jaggedArray[2] = new int[9];

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            // LINKED LIST

            //LinkedList<int> numbers = new LinkedList<int>();
            //numbers.AddFirst(5);
            //numbers.AddLast(17);
            //numbers.AddAfter(numbers.First, 32);
            //numbers.AddAfter(numbers.Last, 32);

            //Console.WriteLine(string.Join(" ", numbers));
            //Console.WriteLine(numbers[0]); // nie możemy dostać się do listy po indexie

            //FUNKCJE

            //HelloWorldFunction();

            //var x = 3;
            //Console.WriteLine("Initial Value " + x);
            //Increment(x);
            //Console.WriteLine("After Increment func " + x);
            //Console.WriteLine();

            //x = IncrementAndAssign(x);
            //Console.WriteLine("After IncrementAndAssign func " + x);
            //Console.WriteLine();

            //RefIncrement(ref x);
            //Console.WriteLine("After RefIncrement func " + x);
            //Console.WriteLine();

            //int y;
            ////Console.WriteLine(y); // nie można :P
            //OutFunction(out y);
            //Console.WriteLine("After OutFunction func " + y);
            //OutFunction(out y);
            //Console.WriteLine();

            //AddTwoVariables(x, y);
            //AddTwoWariablesWithInitial(x);
            //AddTwoWariablesWithInitial(y);
            //AddTwoWariablesWithInitial(x, y);
            //AddTwoWariablesWithInitial(y: x, x: y);

            // TUPLE
            //var t1 = (4.5, 3);
            //Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");

            //(double Sum, int Count) t2 = (4.5, 3);
            //Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

            //var t3 =
            //    (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            //        11, 12, 13, 14, 15, 16, 17, 18,
            //        19, 20, 21, 22, 23, 24, 25, 26, 27, 28);
            //Console.WriteLine(t3.Item27);

            //var returnTuple = ReturnTupleFunc();
            //Console.WriteLine(returnTuple.Item1 + " " + returnTuple.Item2);

            //var robertLewandowski = ReturnNamedTupleFunc();
            //Console.WriteLine(robertLewandowski.Name + " " + robertLewandowski.Surname);

            // ZADANIE DODATKOWE:
            // napisz krzyżówke z użyciem jaggedArray, po wpisaniu każego słowa odśwież konsole
            // po wpisaniu wszystkich haseł możesz zmienić kolor liter hasła
             Crossword.Start();
        }

        public static void HelloWorldFunction()
        {
            Console.WriteLine("Hello World!");
        }

        public static void Increment(int x)
        {
            x++;
            Console.WriteLine("Inside increment func " + x);
        }

        public static int IncrementAndAssign(int x)
        {
            x++;
            Console.WriteLine("Inside IncrementAndAssign func " + x);
            return x;
        }

        public static void RefIncrement(ref int x)
        {
            x++;
            Console.WriteLine("Inside RefIncrement func " + x);
        }

        public static void OutFunction(out int x)
        {
            x = 2;
            Console.WriteLine("Now passed variable equals " + x);
        }

        public static void AddTwoVariables(int x, int y)
        {
            Console.WriteLine("X + Y = " + (x + y));
        }

        public static void AddTwoWariablesWithInitial(int x, int y = 17)
        {
            Console.WriteLine($"X: {x} + Y: {y} = {x+y}");
        }

        public static (int, string) ReturnTupleFunc()
        {
            return (4, "Andrzej");
        }

        public static (string Name, string Surname) ReturnNamedTupleFunc()
        {
            return ("Rober", "Lewandowski");
        }

        public static string RockPaperScissors(string first, string second)
            => (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };
    }
}
