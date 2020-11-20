using System;
using System.Collections;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAY LIST
            ArrayList myArrayList1 = new ArrayList();
            ICollection myArrayList2 = new ArrayList();
            IEnumerable myArrayList3 = new ArrayList()
            {
                1,
                "Two",
                3,
                4.5F
            };

            //foreach (var item in myArrayList1)
            //    Console.WriteLine(item);

            myArrayList1.Add(1);
            myArrayList1.Add("Two");
            myArrayList1.Add(3);
            myArrayList1.Add(4.5);
            var element1 = myArrayList1[0];

            //Console.WriteLine((string)myArrayList1[1]); // łatwo popełnić błąd przy rzutowaniu

            IList myArrayList4 = new ArrayList() { 100, "Two", 12.5, 200 };

            myArrayList4.Insert(1, "Second Item");
            myArrayList4.Insert(2, 100);

            //foreach (var item in myArrayList4)
            //    Console.WriteLine(item);

            myArrayList4.Add(100);

            //foreach (var item in myArrayList4)
            //    Console.WriteLine(item);

            IList myArrayList5 = new ArrayList();
            myArrayList5.Add(10);
            myArrayList5.Add(20);
            myArrayList5.Add(30);

            myArrayList1.InsertRange(2, myArrayList4); // insert into myArrayList1, zaczynamy od indeksu 2

            //foreach (var item in myArrayList1)
            //    Console.WriteLine(item);

            // SORTED LIST

            SortedList sortedList = new SortedList()
            {
                {3, "Three"},
                {4, "Four"},
                {1, "One"},
                {5, "Five"},
                {2, "Two"},
                {100, "A lot"}
            };

            SortedList sortedList2 = new SortedList()
            {
                {"Three", 321},
                {"Four", 412},
                {"One", 42},
                {"Five", 122},
                {"Two", 0},
                {"A lot", 21}
            };

            //Console.WriteLine(sortedList.GetKey(0));
            //Console.WriteLine(sortedList.GetByIndex(10)); // normalne indeksowanie 
            //Console.WriteLine(sortedList[50]); // nr klucza


            //foreach (DictionaryEntry item in sortedList2)
            //{
            //    Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
            //}

            // QUEUE

            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Enqueue("Four");

            //Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Peek());

            //Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

            //while (queue.Count > 0)
            //    Console.WriteLine(queue.Dequeue());

            //HASHTABLE

            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            //ht.Add(4, "REDFVD");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);

            //Console.WriteLine((string)ht[42]);
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);

            ht.Remove("Five");
            Console.WriteLine();
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
        }
    }
}
