using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohsen
{
    class Program
    {
        static void Main(string[] args)
        // here we will use if statement 
        // after if open  a () and gave it value names 
        // and then open a {} and inside of it use Console.WriteLine();
        // for using else if and else , you shuld add them after } and then opne another {}and use Console.WriteLine inside it    
          {            bool ismale = true;
            bool istall = true;
            if (ismale && istall) 
            {
                Console.WriteLine("you are a male and tall ");
                Console.ReadLine();
            

            }else if (ismale || istall)
            {
                Console.WriteLine("you may be tall or may be male or both ");
            }else if (!ismale && !istall) 
            {
                Console.WriteLine(" you are not male and you are not tall");
            }else
            {
                Console.WriteLine("i dont give a damn ");
            }
        }
        

       
    }


}