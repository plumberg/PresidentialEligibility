using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Asgn1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Int32 num;

            Console.WriteLine("Hello!");
            do
            {
                Console.WriteLine("Are you natural Born Citizen? Y - for yes, N - for No");
                input = Console.ReadLine();
                /* if (input.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                 {
                     Console.WriteLine("Y was pressed");
                     Console.ReadKey(true);
                 }*/
            } while (!input.Equals("Y", StringComparison.InvariantCultureIgnoreCase));

            do
            {
                Console.WriteLine("How old are you?");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 35)
                {
                    Console.WriteLine("Should be at least 35 years old");
                }
            } while (num < 35);

            do
            {
                Console.WriteLine("How many years have you resided n the US?");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num < 14);
            Console.ReadKey(true);
        }
    }
}
