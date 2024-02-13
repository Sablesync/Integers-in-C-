using System;

class Program {
        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="args"></param>
    static void Main(string [] args) {

        Console.WriteLine("Hello, World!"); //prints hello world

        //integers stop on a 2 billion
        int ? = 3;
        int ? = 5;
        int ? = 3;
        int ? = ?/?;
        Console.WriteLine(?);

        /*
        //longs biggest
        long ? = 5;
        long ? = 237;
        long ? = a1/b1;
        Console.WriteLine(?);

        //doubles bigger than int
        double a2 = ?;
        double b2 = ?;
        double c2 = ?/?;
        Console.WriteLine(?);

        //shorts stop at 30 thousand
        short ? = 343;
        short ? = 23;
        //short ? = a3/b3;
        //Console.WriteLine(c3);

        //decimals for more accuracy
        ? a4 = 434;
        ? b4 = 53423;
        ? c4 = ?/?;
        Console.WriteLine(?);
        */


        //float
        float a5 = 131;
        float a6 = 343;
        Console.WriteLine(a5/a6);
        
        /*
        //conditional statements
        bool something = a5 + a6 > 500;

        if(something)
            Console.WriteLine("I guessed that right");
        else 
            Console.WriteLine("Yeah right");

        */

        /// <summary>

        int [] s = {1, 2, 3, 4, 5};
        //forloops
        for(int i = 0; i < s.Length; i++)
        {
            Console.WriteLine("This loop is running");
        }

        /*

        //while loops
        while (?)
        {
            Console.WriteLine("Hey buddy");
        }
        */
        
        /*int num = 7;
        Fibonacci(num);
        */
    }

/// <summary>
/// Fibonacci sequence
/// </summary>
/// <param name="num"></param>
    public static void Fibonacci(int num) { //fibonacci sequence
                int sum = 0;
                int i = 0;
            if(num==0){
                Console.WriteLine(num);
            } else if (num<0) {
                Console.WriteLine("Please enter a positive number");
            } else {
                while(i<num) {
                i = i+1;
                sum = sum + i;
            }
            Console.WriteLine($"The fibonacci of {num} is {sum}");
            }
            
        }
}

