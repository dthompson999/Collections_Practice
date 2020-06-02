using System;
using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {

        
        static void Main(string[] args)
        {
        //     Console.WriteLine("Hello World!");

        // int num = 0;
        // int[] array = new int[10];
        // for (int i = 0; i < array.Length; i++)
        // {
        //     array[i] = num + i;
        //     Console.WriteLine(array[i]);
        // }

        // string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
        // {
        //     foreach (string person in names)
        //     {
        //         Console.WriteLine(person);
        //     }
        // }

        
        // bool[] array1 = new bool[10];
        // for (int i=0; i<array1.Length-1; i++)
        // {
        //     array1[i] = true;
        //     array1[i+1] = false;
        //     Console.WriteLine(array1[i]);
        // }
        
        

        List<string> flavors = new List<string> ()
            {
                "chocolate",
                "cookies cookies cookies",
                "strawberry",
                "green tea",
                "nuts",
                "mint",
            };
            foreach (string flavor in flavors)
            {
                Console.WriteLine(flavor);
            }
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            foreach (string flavor in flavors)
            {
                Console.WriteLine(flavor);
            }
            Console.WriteLine(flavors.Count);


        

        }

    }
}
