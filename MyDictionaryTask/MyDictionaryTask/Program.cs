using System;
using System.Collections.Generic;

namespace MyDictionaryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
           
            myDictionary.Add(1, "Ümit");
            myDictionary.Add(2, "Halit");
            myDictionary.Add(3, "Onur");
            myDictionary.Add(3, "Devrim");

            Console.WriteLine(myDictionary.Lenght);
            Console.ReadLine();
        }
    }
}
