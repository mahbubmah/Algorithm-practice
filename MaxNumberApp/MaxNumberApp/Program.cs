using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[7] {12, 15, 46, 48, 79, 12, 45};
            int largest = i[0];
            //for (int j = 0; j < 6; j++)
            //{
            //    if (i[j+1]>=largest)
            //    {
            //        largest = i[j + 1];
            //    }
            //}

            foreach (int i1 in i)
            {
                if (largest<=i1)
                {
                    largest = i1;
                }
            }

            Console.WriteLine(largest);
            Console.ReadKey();
        }
    }
}
