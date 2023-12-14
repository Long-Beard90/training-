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
            Console.Write("PLEASE ENTER YOUR FIRST NUMBER : ");
            Double numone=Convert.ToDouble(Console.ReadLine());
            Console.Write("PLEASE ENTER YOUR SECOUND NUMBER : ");
            Double numtwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(numone + numtwo);
            Console.ReadLine();
        }



    }


}