using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

        public int Swap(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            return temp;
            
        }





        static void Main(string[] args)
        {
            //int a;
            //a = Convert.ToInt32(Console.ReadLine());
            //while (a >= 1)
            //{
            //    int b = a--;
            //    int c = a*b;

            //    Console.WriteLine("Value of c is {0}", c);

            //}

            //for (a = 10; a < 20; a++)
            //{
            //    Console.WriteLine(a);

            //}

            Program n = new Program();
            int a = 100;
            int b = 200;
            Console.WriteLine("Pre zamenje vrednost a je {0}", a);
            Console.WriteLine("Pre zamene vrednost b je {0}", b);

            n.Swap(b, a);
            Console.WriteLine("Nakon zamene vrednost a je {0}", a);
            Console.WriteLine("Nakon zamene vrednost b je {0}", b);

            //int a, b, temp;
            //Console.WriteLine("Vrednost a je");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Vrednost b je");
            //b = Convert.ToInt32(Console.ReadLine());

            //temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine("Vrednost a je {0}, a vrednost b je {1}", a, b);

            Console.ReadKey();
        }
    }
}
