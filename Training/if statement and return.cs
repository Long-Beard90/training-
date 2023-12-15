using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Mohsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first number :");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("enter secound number :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("bigger number is : ");
            Console.WriteLine(Max(num1, num2));

            Console.ReadLine();

            
        }
        static int Max(int num1 , int num2)
        {
            int resualt;
            if (num1 > num2)
            {
                resualt = num1;
            }else
            {
                resualt = num2;
            }
            return resualt;
           
        }
        

       
    }


}