using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split(' ');          
            int n = 0, max = 0;
            for (int i = 0; i < stringArray.Length; i++) 
            {
                if (stringArray.Length > max) 
                {
                    max = stringArray[i].Length; 
                    n = i;
                }
            }
            Console.Write("Самое длинное слово {0}", stringArray[n]); 
            Console.ReadKey();

        }
    }
}
