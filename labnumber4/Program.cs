using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labnumber42
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("please enter a number");
                string input = Console.ReadLine();

                int num = int.Parse(input);
                for (int i = 1; i <= num; i++)
                {
                    int square = i * i;
                    int cube = i * i * i;
                    Console.WriteLine("{0}{1}{2}{3}{4}", i, "\t", square, "\t", cube );
                    
                }
                //for (int i = 1; i <= num; i++)
                //{
                    

                //    Console.WriteLine(square);
                //}
                //for (int i = 1; i <= num; i++)
                //{
                    

                //    Console.WriteLine(cube);
                //}

                { 
                    Console.WriteLine();
                    run = Continue();

                }

            }

        }
        public static bool Continue()

        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string info = Console.ReadLine();
            string input = info.ToLower();
            bool goOn = true;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }









            return goOn;
        }
    }
}      
 




            
                



                    


                

            
        
    

        
    

    
    

