using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detyra11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}