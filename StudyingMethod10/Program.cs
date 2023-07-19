using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingMethod10
{
    internal class Program
    {
        static int Sum(int x, int y)   // 3. method
        {
            return x + y;
        }

        //static int Sum(int x, int y) --> 2. method
        //{
        //    return x + y;
        //}

        //static int Sum(int x) --> 1. method
        //{
        //    return x + 3;
        //}
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(9)); --> 1.output

            //Console.WriteLine(Sum(9,5)); --> 2. output

            int z = Sum(9, 7);
            Console.WriteLine(z);     //   --> 3. output

            Console.Read();
        }
    }
}

