using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 10; i++)
            {
                int randomNum = random.Next(5) + 3;
                
            }
            Console.ReadKey();
        }
    }
}
