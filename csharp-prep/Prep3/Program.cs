using System;

class Program
{
    static void Main(string[] args)

    {
       Console.Write("What is the magic number? ");
        int magic = int.Parse (Console.ReadLine());


       Random randomGenerator = new Random();
       magic = randomGenerator.Next(1 , 101);
       
       int guess = -1 ;

       while  (guess  != magic )

        {
        Console.Write("What is your guest? ");

         guess= int.Parse(Console.ReadLine());
         
        if (magic > guess)
        {Console.WriteLine("Higher");}
        

        else if  (magic < guess )

        {Console.WriteLine("Lower");}

        else 
        {Console.WriteLine("You guess it");}

        }
      
       
         
        


    }
}