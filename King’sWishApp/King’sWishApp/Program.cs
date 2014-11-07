using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King_sWishApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong c = 0,r=0,x=0;
            
            c=Convert.ToUInt32(Console.ReadLine());
            

            for (ulong i = c-1; i >=1; i--)
            {
                for (ulong j = 2; j <c-1; j++)
                {
                    r = i*j;
                    if (c==r)
                    {
                        if (i>j)
                        {
                            string b=i+","+j;
                            Console.WriteLine(b);
                            goto n;
                        }
                    }
                }
                if (i==1)
                {
                    string a = "Impossible";
                    Console.WriteLine(a);

                }
            }
            n:
            Console.ReadKey();
        }
    }
}
