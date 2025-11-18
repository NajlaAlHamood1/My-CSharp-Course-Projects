using System;   // 🎤 Provides Console for input/output.

namespace EmployeeComparisonApp   // 🏢 Matches the namespace of Employee.
{
    class Program
    {
        // 🚀 The command center of our program.
        static void Main(string[] args)
        {
            // 👷 Creating the first employee with unique identity and name.
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "Najla",
                LastName = "AlHamood"
            };

            // 👨‍🔧 Creating the second employee—same Id to trigger equality!
            Employee emp2 = new Employee
            {
                Id = 101,
                FirstName = "John",
                LastName = "Wick"
            };

            // 🧪 Running the equality test using our custom overloaded operator.
            bool areEqual = emp1 == emp2;

            // 📢 Display the equality result with flair.
            Console.WriteLine("Are the two employees equal (based on Id)? " + areEqual);

            // 🔄 Also show the result of the != operator for completeness.
            bool areNotEqual = emp1 != emp2;
            Console.WriteLine("Are the two employees NOT equal? " + areNotEqual);

            // 🧘 Pause so the console doesn't blink away.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
