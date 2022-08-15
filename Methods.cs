using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static int OneThousand()
        {
            {
                var List1000 = new List<int>();
                int start = 1000;

                do
                {
                    Console.WriteLine($" {start}");
                    start--;
                    List1000.Add(start);

                } while (start >= -1000);
                return start;   

            }



        }
        public static int MultiplesOf3()
        {
            var ListOfThrees = new List<int>();

            for (int threeXthree = 3; threeXthree <= 999 ; threeXthree += 3) 
            {
                ListOfThrees.Add(threeXthree);
                Console.WriteLine($"{threeXthree}");
                
            }
            return ListOfThrees.Count;
            
            
        }


        public static Boolean ToF(int x, int y)
        {
             
            if(x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
           
            

        }
        
        public static bool IsItEven(int c)
        {
            if (c % 2 == 0)
            {
                Console.WriteLine($"{c} is an even number");
                return true;
            }
            else
            {
                Console.WriteLine($"{c} is an odd number");
                return false;
            }


        }
        
        public static bool IsItPositive(int num2)
        {
            if (num2 < 0)
            {
                Console.WriteLine($"{num2} is negative");
                return false;
            }
            else 
            {
                Console.WriteLine($"{num2} is positive");
                return true;
            }      
            
      
        }

        public static bool AreTheyLegal(int num3)
        {
            if (num3 >= 18)
            {
                Console.WriteLine($"Congradulations! \n" +
                    $"You are old enough to vote! \n" +
                    $"Dont waste it!");
                return true;
            }
            else
            {
                Console.WriteLine("You are not old enought to vote! \n" +
                    "GO HOME");
                return false;
            }


        }

        public static bool InRange(int num4)
        {
            if (num4 >= -10 && num4 <= 10)
            {
                Console.WriteLine($"The number {num4} \n" +
                    $" is in the expected range :)");
                return true;

            }
            else
            {
                Console.WriteLine($"The number {num4} \n" +
                    $"is out of the expected range, sorry!");
                return false;
            }
        }        

        public static int MultiplicationTable(int num5)
        {
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{num5} x {i} = {num5 * i}");
            }
            return num5;


        }



    }

}   
