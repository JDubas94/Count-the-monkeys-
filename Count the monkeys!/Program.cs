using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_monkeys_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of monkeys!");

           int number = int.Parse(Console.ReadLine());

            int[] newArray = new int[number];

            for (int i = 0; i < newArray.Length; i++) 
            {
                newArray[i] = i +1;
                
                Console.WriteLine(newArray[i]);
            }

            Console.ReadLine();
        }
    }
}
