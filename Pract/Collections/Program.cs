using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{

    class Program
    {
        static void PrintCollection(IEnumerable collection)
        {
            foreach (object obj in collection)
                Console.WriteLine(obj);
        }
        static void Main(string[] args)
        {
            #region ArrayList
            ArrayList list = new ArrayList();

            list.Add("World");
            list.Add("Hello");

            Console.WriteLine("Count: {0}", list.Count);
            Console.WriteLine("Capacity: {0}", list.Capacity);

            list.Sort();

            PrintCollection(list);

            Console.WriteLine("list[0] = {0}", list[0]);
            Console.WriteLine("list[0] = {0}", list[1]);

            Console.WriteLine("Contains Hello: {0}", list.Contains("Hello"));
            Console.WriteLine("Contains Foo: {0}", list.Contains("Foo"));
            Console.WriteLine();
            #endregion

            #region Hashtable
            Hashtable table = new Hashtable();

            table["Keith"] = 42;
            table["Aaron"] = 33;
            table["Fritz"] = 37;

            Console.WriteLine("Keith is {0} years old, table", table["Keith"]);
            Console.WriteLine("Aaron is {0} years old, table", table["Aaron"]);
            Console.WriteLine("Fritz is {0} years old, table", table["Fritz"]);

            Console.WriteLine("ContainsKey Foo? {0}", table.ContainsKey("Foo"));

            PrintCollection(table.Keys);
            PrintCollection(table.Values);
            Console.WriteLine();
            #endregion

            #region SortedList
            SortedList sortlist = new SortedList();

            sortlist["Keith"] = 42;
            sortlist["Aaron"] = 33;
            sortlist["Fritz"] = 37;

            Console.WriteLine("Keith is at index {0}", sortlist.IndexOfKey("Keith"));
            Console.WriteLine("Aaronis at index {0}", sortlist.IndexOfKey("Aaron"));
            Console.WriteLine("Fritz is at index {0}", sortlist.IndexOfKey("Fritz"));

            Console.WriteLine("Keith is {0} years old", sortlist["Keith"]);
            Console.WriteLine("Aaron is {0} years old", sortlist["Aaron"]);
            Console.WriteLine("Fritz is {0} years old", sortlist["Fritz"]);

            Console.WriteLine("ContainsKey Foo? {0}", table.ContainsKey("Foo"));

            PrintCollection(sortlist.Keys);
            PrintCollection(sortlist.Values);
            Console.WriteLine();
            #endregion

            #region Stack
            Stack stack = new Stack();

            stack.Push("Every");
            stack.Push("Does");
            stack.Push("Good");
            stack.Push("Boy");
            stack.Push("Fine");

            Console.WriteLine("peek returns {0}", stack.Peek());

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
            PrintCollection(stack);
            Console.WriteLine();
            #endregion

            #region Queue
            Queue queue = new Queue();

            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Forth");
            queue.Enqueue("Fifth");

            Console.WriteLine("peek returns {0}", queue.Peek());

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

            Console.WriteLine();
            #endregion
        }
    }
}
