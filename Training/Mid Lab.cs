using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohsen
{
    class Program
    {
        static void Main(string[] args)
        {
            String color, noun, celeberity;

            Console.WriteLine("enter a color : ");
            color = Console.ReadLine();
            Console.WriteLine("enter a noun :");
            noun = Console.ReadLine();
            Console.WriteLine("enter a celebrity name :");
            celeberity = Console.ReadLine();

            Console.WriteLine("ROSES ARE "+ color);
            Console.WriteLine(noun + "ARE BLUE ");
            Console.WriteLine("I LOVE " + celeberity);
            Console.ReadLine();


        }



    }


}