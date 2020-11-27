using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //GENERICS AND NULLABLE

            //int? a = null;
            //int a = 7; // bez sensu wtedy sprawdzać czy jest nullem
            int? a = 7;
            int b = a ?? -1;
            //Console.WriteLine(b);

            //List<int> numbers = null;
            //int? i = null;

            //numbers ??= new List<int>();
            //numbers.Add(i ??= 17);
            //numbers.Add(i ??= 20); // i nie jest już nullem 

            //Console.WriteLine(string.Join(" ", numbers));
            //Console.WriteLine(i);

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine(queue.Dequeue());

            //Dictionary<int, string> animals = new Dictionary<int, string>();
            //animals.Add(1, "Dog");
            ////animals.Add(1, "Cat");
            //animals.Add(2, "Cat");
            //Console.WriteLine(animals[1]);
            //Console.WriteLine(animals.Count);

            //string animal;
            //if (animals.TryGetValue(1123, out animal))
            //    Console.WriteLine(animal);
            //else
            //    Console.WriteLine("Record doesn't exists");

            //animals[1] = "Zebra";
            //Console.WriteLine(animals[1]);

            //var genericClass = new GenericExample<double>();
            //Console.WriteLine(genericClass.Max(2.5, 12.1));

            //LAMBDA

            
            Func<int, int> square = x => x * x;
            //Console.WriteLine(square(5));

            Func<int, int, bool> testForEquality = (x, y) => x == y;
            //Console.WriteLine(testForEquality(1, 1));
            //Console.WriteLine(testForEquality(1.0, 1));
            //Console.WriteLine(testForEquality("Kot", 1));

            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            //Console.WriteLine(isTooLong(2, "Kot"));

            //Action<string> greet = name =>
            //{
            //    var a = 4;
            //    string greeting = $"Hello {name} {a}!";
            //    Console.WriteLine(greeting);
            //};

            //greet("World");

            //LINQ

            List<int> numbers = new List<int>() { 2, 3, 4, 5, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            //Console.WriteLine(string.Join(" ", squaredNumbers));

            var squaredNumbersQuery = from n in numbers select n * n;
            //Console.WriteLine(string.Join(" ", squaredNumbersQuery));

            var maxValue = numbers.Max();
            Console.WriteLine("Max value " + maxValue);

            var sumValues = numbers.Sum();
            Console.WriteLine("Sum of all Numbers " + sumValues);

            var countValues = numbers.Count;
            Console.WriteLine("Count elements " + countValues);

            var anyLessThanThree = numbers.Any(n => n < 3);
            Console.WriteLine("Any element Less than 3? " + anyLessThanThree);

            var allEven = numbers.All(n => n % 2 == 0);
            Console.WriteLine("All elements even? " + allEven);

            var elementsMoreThan4 = numbers.FindAll(n => n > 4);
            Console.WriteLine("All elements greater than 4: " + string.Join(" ", elementsMoreThan4));

            var firstTwo = numbers.Take(2);
            Console.WriteLine("First Two Elements " + string.Join(" ", firstTwo));

            var skipFirstTwo = numbers.Skip(2).Take(2);
            Console.WriteLine("Just skip 2 elements " + String.Join(" ", skipFirstTwo));

            var distinctValues = numbers.Distinct();
            Console.WriteLine("Distinct values " + String.Join(" ", distinctValues));

            var list = new List<int>();

            var firstValue = numbers.FirstOrDefault(n => n > 40);
            Console.WriteLine("First Value " + firstValue);

            var lastValue = numbers.Last();
            Console.WriteLine("Last Value " + lastValue);

            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };

            var longWords = words.Where(w => w.Length > 8);
            Console.WriteLine(string.Join(" ", longWords));

            var longwordsQuery = from w in words where w.Length > 8 select w;
            Console.WriteLine(string.Join(" ", longwordsQuery));



            var dogs = new List<Pet>()
            {
                new Pet() {Age = 2, Name = "Burek"},
                new Pet() {Age = 3, Name = "Azor"},
                new Pet() {Age = 12, Name = "Reksio"},
                new Pet() {Age = 1, Name = "Pimpek"}
            };

            var cats = new List<Pet>()
            {
                new Pet() {Age = 7, Name = "Behemot"},
                new Pet() {Age = 3, Name = "Tom"},
                new Pet() {Age = 17, Name = "Klakier"}
            };

            var species = new List<Species>()
            {
                new Species() {Cost = 213.20, Pets = dogs, Name = "Pieski"},
                new Species() {Cost = 123.40, Pets = cats, Name = "Kotki"}
            };


            //ZADANKA
            //Where
            //a) Wybierz wszystkie psy o parzystym wieku.

            //b) Wybierz gatunki zwierząt o cenie wyższej niż 150.

            //Select
            //a) Wybierz imiona psów i dopisz na początku "Pieseł" ("Burek" -> "Pieseł Burek")

            //b) Wybierz nazwy gatunków wraz z ceną zaokrągloną do liczby dziesiątek
            var speciesWithPrices = species.Select(s =>
                new {Name = s.Name, Price = (int) Math.Round(s.Cost / 10) * 10 });
            foreach (var s in speciesWithPrices)
            {
                Console.WriteLine($"{s.Name} - {s.Price}");
            }
            Console.WriteLine();

            //Nie było na zajęciach - przykład użycia SelectMany() - w skrócie służy do "spłaszczania" kolekcji
            // wypisz wszystkie zwierzęta Name + lata

            //Kombinacje
            //a) Wybierz imiona wszystkich zwierząt młodszych niż 3 lata

            //b) Czy jest jakieś zwierze, którego wiek jest równy liczbie znaków imienia? (użyć Any(); "Behemot lat 7", "Tom lat 3")

            //c) Policz wartość wszystkich zwierząt w species (użyć Sum())

            //d) Czy wszystkie zwierzęta starsze od 5 lat mają w imieniu literę 'o'? (Użyć All(); "Klakier lat 17")

            //przykład użycia grupowania
            var petsGroupedByAge = species.SelectMany(s => s.Pets).GroupBy(p => p.Age);

            foreach (var pets in petsGroupedByAge)
            {
                Console.WriteLine($"Wiek: {pets.Key}");
                foreach (var pet in pets)
                {
                    Console.WriteLine(pet.Name);
                }
            }
        }
    }
}
