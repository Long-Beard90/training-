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
            // for showing this method in the terminal we must use this method in the Main method : this will show us  : hello users !
            SayHi();
            Sayhito("Mohsen");
            Sayhito("Jhon");
            // cool thing about method is we can use it as many time
            HiandAge("Arthur", 55);



            int[] goodnumbers = { 10, 20, 4, 5, 2 };
            string[] friend = new string[] { };
            Console.WriteLine(goodnumbers[0]);
            Console.WriteLine("the number is : " + goodnumbers[0]);
            Console.ReadLine();

        }
        // for making a method we use static void name-of-method ()
        // and then in {} , we will code anything that we want 
        // and remember for showing this method in the terminal we must use this method in the Main method !!!!
        static void SayHi()
        {
            Console.WriteLine("hello users !");
        }
        static void Sayhito(string name)
        {
            Console.WriteLine("hello " + name);
            // in this way we can use it as giving it a parameter 
            // static void name-of-method(type-of-value name-of-thing )
            // and then in { } we can use it , and for shwoing it we must use it in Main method
        }
        static void HiandAge(string name, int age)
        {
            Console.WriteLine("hello " + name + "you are " + age);
            // and we can use type of values as we want in just one method ...
        }


    }


}