using System;

namespace C__Work
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var counter = 0; counter <= 100; counter++)
            {

                if (counter % 15 == 0)
                Console.WriteLine("FizzBuzz");

                else if (counter % 3 == 0)
                Console.WriteLine("Fizz");

                else if (counter % 5 ==0)
                Console.WriteLine("Buzz");

            else {
                Console.WriteLine(counter);
            }
            }

        }    

    }
}



            // for (var counter = 0; counter <= 100; counter++)
            // {
            //     foreach (int i in counter) {
                    
            //         if (i % 3 == 0) {
                        
            //             Console.WriteLine("Fizz");
            //         }
            //     }
                
            //     Console.WriteLine(counter);
            // }

                // if (counter % 3 == 0 && counter % 5 == 0)
                // Console.WriteLine("FizzBuzz");
            // var counter = 0;
            // while (counter <100) {
            //     if (counter % 3 == 0) {
            //         Console.WriteLine("Fizz");

            //     } else {
            //         Console.WriteLine(counter);
            //     }
            //     counter++;
            // }

