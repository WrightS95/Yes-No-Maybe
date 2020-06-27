using System;
using System.Collections.Generic;


namespace testforvs19
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; //answer = computer's answer, input = user input
            string[] choices = { "yes", "no", "maybe" }; //options for the computer to reply
            

            Random random = new Random(); 
            int answer = random.Next(choices.Length); //computer chooses between options in choices

            do
            {               
                Console.WriteLine("Yes?");
                input = Console.ReadLine();
                Console.WriteLine($"{choices[answer]}\n");


            } while (input != "escape"); //still need to change it so it auto stops if the user enters escape
            
        }
    }
}
