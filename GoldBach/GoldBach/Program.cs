using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBach
{
    class Program
    {

        static void Main(string[] args)
        {
            int h = 0, l = 0, r = 0, x = 0, count = 0;

            l = Convert.ToInt32(Console.ReadLine());

            h = Convert.ToInt32(Console.ReadLine());
            int gc = 0;

            for (int i = l; i <= h; i++)
            {
                if (i % 2 == 0)
                {
                    int k = 0;
                    for (int j = 0; j <= i; j++)
                    {
                        k = i - j;
                        if (IsPrime(k) && IsPrime(j))
                        {
                            if (i==j+k)
                            {
                                count++;
                            }
                        }
                    }

                    gc = gc+(count/2);
                    count = 0;
                }
            }
            string a = gc.ToString();
            Console.WriteLine(gc);
            Console.ReadKey();
        }

        private static bool IsPrime(int i)
        {
            if (i == 0)
            {
                return false;
            }
            if (i == 1)
            {
                return false;
            }

            for (int j = 2; j < i / 2; j++)
            {
                
                if (i % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
