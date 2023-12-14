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
        {
            bool ismale = true;
            bool istall = true;
            if (ismale && istall) 
            {
                Console.WriteLine("you are a male and tall ");
                Console.ReadLine();
            

            }else if (ismale || istall)
            {
                Console.WriteLine("you may be tall or may be male or both ");
            }else if (ismale && istall) 
            {
                Console.WriteLine()
            }
        }
        

       
    }


}