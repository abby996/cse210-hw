using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your First name");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your Last name");
        string lastname= Console.ReadLine();

        Console.Write($"your name is {lastname}, {firstname} {lastname}");
    }  

} 