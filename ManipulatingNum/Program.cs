using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingNum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();
            List<int> ls_nonzero = new List<int>();
            List<int> l_even = new List<int>();
            List<int> l_odd = new List<int>();
            List<int> l_zero= new List<int>();
            List<int> l_neg = new List<int>();
            Console.Write("Enter the number of times you want to input data: ");
            int numOfTime = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <= numOfTime; n++)
            {
                Console.Write("Enter a number:");
                string numstr = Console.ReadLine();
                int num = Convert.ToInt32(numstr);
                ls.Add(num);
                if (num != 0)
                {
                    ls_nonzero.Add(num);
                }
            }
            
            foreach(int n in ls)
            {
                if (n == 0)
                {
                    l_zero.Add(n);
                }else if (n % 2 == 0)
                {
                    l_even.Add(n);
                }else if (n % 2 != 0)
                {
                    l_odd.Add(n);
                }else if (n < 0)
                {
                    l_neg.Add(n);
                }
            }

            //print values now:
            Console.WriteLine("Total numbers entered = " + ls.Count());
            Console.WriteLine("Sum of all numbers inputted = " + ls.Sum());
            //Your prints now
            Console.WriteLine(" ");
            Console.WriteLine("Total number of non zero integers =" + ls_nonzero.Count());

            Console.WriteLine("Total number of even integers =" + l_even.Count());
            Console.WriteLine("Sum of even integers =" + l_even.Sum());
            Console.WriteLine("Total number of odd integers =" + l_odd.Count());

            //other data
            Console.WriteLine("Sum of odd integers =" + l_odd.Sum());

        }
    }
}
