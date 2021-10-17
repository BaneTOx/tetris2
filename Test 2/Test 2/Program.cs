using System;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameword = "John";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != nameword && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("What is the name of the son? ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
                
                
            }
            if(outOfGuesses)
            {
                Console.Write("Why...");
                Console.ReadLine();
                Console.Write("I tried so hard to teach you...");
                Console.ReadLine();
                Console.Write("...");
                Console.ReadLine();
            }
            else
            {
                Console.Write("You won, but there is room for improvement...");
            }


            

            string Son = "John";
            string Father = "Trump";
            string Sister = "Jenna";
            string Mother = "Harley";

            string proceed = "Yes";
            string deny = "No";
            string choice = "";
            string choices = "";

            int Sonage = 14;
            int Fatherage = 36;
            int Sisterage = 8;
            int Motherage = 35;
            bool theChoice = false;

            string userCommand = Console.ReadLine();
            
            while(choice != proceed && !theChoice)
            {
                if(theChoice = true)
                {
                    Console.WriteLine("Do you want to read a 'story'? ");
                    choice = Console.ReadLine();

                    Console.Write("Hello, my name is " + Son + " I am " + Sonage + " years old.");
                    Console.Write("I have a Father called " + Father + " He is " + Fatherage + " years old.");
                    Console.Write("I also have a Mother and a Sister.. My sister is called " + Sister + ", She is " + Sisterage + " years old.");
                    Console.Write("And my mother's name is " + Mother + ", she turned " + Motherage + " a few months ago.");
                    Console.ReadLine();
                }
                else
                {
                    theChoice = false;
                }

                if(theChoice)
                {
                    Console.Write("Ok then...");
                    Console.ReadLine();
                }
                

            
            
            
            
            
            
            
            

            

                
                              
            }








        }
    }
}
