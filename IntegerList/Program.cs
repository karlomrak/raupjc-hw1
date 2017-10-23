using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;

namespace Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            IIntegerList list = new IntegerList();
            list.Add(1); // [1]
            list.Add(2); // [1 ,2]
            list.Add(3); // [1 ,2 ,3]
            list.Add(4); // [1 ,2 ,3 ,4]
            list.Add(5); // [1 ,2 ,3 ,4 ,5]
            list.RemoveAt(0); // [2 ,3 ,4 ,5]
            list.Remove(4); //[2 ,3 ,4]
            Console.WriteLine(list.Count); // 3
            Console.WriteLine(list.Remove(100)); // false
            Console.WriteLine(list.RemoveAt(5)); // false
            list.Clear(); // []
            Console.WriteLine(list.Count); // 0
            Console.Read();
        }


        
}
}
