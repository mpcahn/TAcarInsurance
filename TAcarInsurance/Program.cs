using System;

namespace TAcarInsurance
{
    class Program
    {
        static void Main()
        {
            // Ask the following questions:
            // What is your age ?
            Console.WriteLine("What is your age?");
            byte age = Convert.ToByte(Console.ReadLine());

            // Have you ever had a DUI?
            Console.WriteLine("Have you ever had a DUI? (answer true or false)");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // How many speeding tickets do you have?
            Console.WriteLine("How many speeding tickets do you have?");
            byte tickets = Convert.ToByte(Console.ReadLine());

            // Use the following qualification rules to determine if the applicant qualifies for car insurance:
            // Applicants must be over 15 years old.
            // Applicants must not have any DUI’s.
            // Applicants must not have more than 3 speeding tickets.
            // Used for debugging: Console.WriteLine("age: " + age + ", dui: " + dui + ", tickets: " + tickets);
            bool qualified = ((age > 15) && (dui != true) && (tickets <= 3));

            // Print the result of the boolean expression created from the above business rules.
            Console.WriteLine("Quailfied?");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
