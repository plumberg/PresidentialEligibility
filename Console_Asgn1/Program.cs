using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asgn_01_Lib;

namespace Console_Asgn1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Int32 numTerms, numAge, numResided;
            Boolean rebelled = false;
            Boolean citizen = false;
            Boolean check;

            Console.WriteLine("Hello!");
            
                Console.WriteLine("Are you natural Born Citizen? Y - for yes, N - for No");
                input = Console.ReadLine();
                 if (input.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                 {
                     //Console.WriteLine("Y was pressed");
                     citizen = true;
                    
                 }else if (input.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                {
                    //Console.ReadKey(true);
                    citizen = false;
                }
     

           

                Console.WriteLine("How old are you?");
                numAge = Convert.ToInt32(Console.ReadLine());
               
            
                Console.WriteLine("How many years have you resided in the US?");
                numResided = Convert.ToInt32(Console.ReadLine());
            
           
                Console.WriteLine("How many prior terms you've served?");
                numTerms = Convert.ToInt32(Console.ReadLine());
               

                Console.WriteLine("Did you rebell against US? Y for yes N for No");
                input = Console.ReadLine();
         
                
                if (input.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                {
                //Console.WriteLine("Y was pressed");
                rebelled = true;

                }
                else if (input.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                {
                //Console.ReadKey(true);
                rebelled = false;
                }



            Logic logic = new Logic(citizen,numResided,numAge,numTerms,rebelled);
            check = logic.CheckElligibility();
            if (check==true)
            {
                Console.WriteLine("You are eligible for the Presidential Election");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible");
                Console.ReadKey(true);
            }


        }

        
    }
}
