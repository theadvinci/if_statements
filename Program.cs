using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string firstName;
            string lastName;
            int yearOfBirth;

            Console.WriteLine("How may I refer to you puny human?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is the identifying moniker of your pathetic lineage?");
            lastName = Console.ReadLine();

            Console.WriteLine("Type your year of materialization:");
            yearOfBirth = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"I greet you puny {firstName} of the {lastName} clan!");
            Console.WriteLine($"Your amortization has lasted for {2019 - yearOfBirth} years.");

            Console.ReadLine();*/




            /*
                Start:
                int userNumber;

                Console.WriteLine("Enter a number from 1 to 10.");
                userNumber = Int32.Parse(Console.ReadLine());

                if (userNumber < 5)
                {
                    Console.WriteLine("The number is smaller than 5.");
                }


                else if (userNumber > 5)
                {
                    Console.WriteLine("The number is larger than 5.");
                }


                else if (userNumber == 5)
                {
                    Console.WriteLine("The number is equal to 5.");
                }


                Console.ReadLine();

                goto Start; */
            Start:
            int userNumber;

            Console.WriteLine("Enter a number from 1 to 10.");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 10 )

            {
                if (userNumber < 5)
                {
                    Console.WriteLine("The number is smaller than 5.");
                }
                
                else if (userNumber > 5)
                {
                    Console.WriteLine("The number is larger than 5.");
                }

                else
                {
                    Console.WriteLine("The number is equal to 5.");
                }
            }

            else 
            {
                Console.WriteLine("You STUPID! Enter a number FROM 1 TO 10 you dummy!");
            }

            
            goto Start;

        }
    }
}
