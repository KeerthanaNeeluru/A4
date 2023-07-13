using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number : ");
            num=int.Parse(Console.ReadLine());
            if (num > 0)
            {

                Console.WriteLine("The number is positive");
                
            }
            else if(num<0){
                Console.WriteLine("The number is negative");
            }
            else if (num == 0)
            {
                Console.WriteLine("Th number is Zero ");
            }
            var res = (num % 2 == 0) ? "The number is even" : "The number is odd";
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
