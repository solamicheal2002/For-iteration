using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) 
            {
                if (i == 7) 
                {
                    Console.WriteLine("David is HOME\a");
                    break;
                }
            }




            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            } 
               

            Console.ReadLine();
        }
    }
}
