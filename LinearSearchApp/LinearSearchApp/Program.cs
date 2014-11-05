using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums=new int[5]{15,56,45,48,78};

            int x = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            foreach (int num in nums)
            {
                
                if (num==x)
                {
                    Console.WriteLine("got it");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No match found");
            }
            Console.ReadKey();
        }
    }
}
