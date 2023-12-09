using System;

class Program {
    static void Main(string [] args) {
        Console.WriteLine("Hello, World!");

//integers stop on a 2 billion
        int a = 3;
        int b = 5;
        int d = 3;
        int c = a/d;
        Console.WriteLine(c);
//longs biggest
        long a1 = 5;
        long b1 = 237;
        long c1 = a1/b1;
        Console.WriteLine(c1);
//doubles bigger than int
        double a2 = 954;
        double b2 = 3453;
        double c2 = a2/b2;
        Console.WriteLine(c2);
//shorts stop at 30 thousand
        short a3 = 343;
        short b3 = 23;
      //  short c3 = a3/b3;
        //Console.WriteLine(c3);
//decimals for more accuracy
        decimal a4 = 434;
        decimal b4 = 53423;
        decimal c4 = 6M/5M;
        Console.WriteLine (c4);
//float
        float a5 = 131;
        float a6 = 343;
        Console.WriteLine(a5/a6);


string s = "ahs ajshashdhjask ";
//string g = s.ToArray();

 //conditional statements
    bool something = a5 + a6 > 500;

    if(something)
        Console.WriteLine("I guessed that right");
    else 
        Console.WriteLine("Yeah right");


        //forloops
    for(int i = 0; i < s.Length; i++)
    {
        Console.WriteLine("This loop is running");
    }

    //while loops
    while (something)
    {
        Console.WriteLine("Hey buddy");
    }


    }

    

}