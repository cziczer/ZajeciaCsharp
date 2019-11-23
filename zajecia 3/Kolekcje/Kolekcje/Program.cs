using System;
using System.Collections;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList myArryList1 = new ArrayList();
            //ICollection myArryList3 = new ArrayList();
            //IEnumerable myArryList4 = new ArrayList()
            //{
            //    1,
            //    "Two",
            //    3,
            //    4.5F
            //};
            ////foreach (var val in myArryList4)
            ////    Console.WriteLine(val);
            //myArryList1.Add(1);
            //myArryList1.Add("Two");
            //myArryList1.Add(3);
            //myArryList1.Add(4.5);
            //var el1 = myArryList1[0];
            //int a = 1;

            //Console.WriteLine((string)myArryList1[1]);
            //Console.WriteLine((int)myArryList1[2]);

            //IList arryList2 = new ArrayList()
            //{
            //    100, 200
            //};
            //IList arrayList = new ArrayList() { 100, "Two", 12.5, 200 };
            //IEnumerable myArryList = new ArrayList();
            //myArryList.Add(1);
            //myArryList.Add("Two");
            //myArryList.Add(3);
            //myArryList.Add(4.5);

            //myArryList.Insert(1, "Second Item");
            //myArryList.Insert(2, 100);

            //foreach (var val in myArryList)
            //    Console.WriteLine(val);

            //IList arryList1 = new ArrayList();
            //arryList1.Add(100);
            //arryList1.Add(200);

            //IList arryList2 = new ArrayList();
            //arryList2.Add(10);
            //arryList2.Add(20);
            //arryList2.Add(30);

            //arryList2.InsertRange(2, arryList1);

            //foreach (var item in arryList2)
            //    Console.WriteLine(item);


            //SortedList sortedList = new SortedList()
            //{
            //    {3, "Three"},
            //    {4, "Four"},
            //    {1, "Razdwatrzy"},
            //    {5, "Five"},
            //    {2, "Two"}
            //};
            //Console.WriteLine((String)sortedList[1]);
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
            //}


           //Queue queue = new Queue();
           // queue.Enqueue(3);
           // queue.Enqueue(2);
           // queue.Enqueue(1);
           // queue.Enqueue("Four");

           // Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

           // Console.WriteLine(queue.Peek());
           // Console.WriteLine(queue.Peek());
           // Console.WriteLine(queue.Peek());

           // Console.WriteLine("Number of elements in the Queue: {0}", queue.Count);

           // while (queue.Count > 0)
           //     Console.WriteLine(queue.Dequeue());

            //Hashtable
            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(4, "REDFVD");
            ht.Add(5, null);
            ht.Add("Fv", "Five");
            ht.Add(8.5F, 8.5);
            //Console.WriteLine((string)ht[2]);
            foreach (DictionaryEntry item in ht)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);
            //ht.Remove("Fv");
        }
    }
}
