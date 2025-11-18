using System;   // 🎤 Provides access to Console.

namespace QuittableDemoApp  // 🧩 Matches other files.
{
    class Program
    {
        static void Main(string[] args)   // 🚦 App entry point.
        {
            // 🛠️ Create a new Employee instance with some sample data.
            Employee emp = new Employee
            {
                Id = 202,
                FirstName = "Najla",
                LastName = "AlHamood"
            };

            // 🎭 POLYMORPHISM MAGIC:
            // We assign the Employee object to a variable of type IQuittable.
            // 👉 This works because Employee *implements* IQuittable.
            IQuittable quitter = emp;

            // 🧨 Now call Quit() through the interface reference.
            // The Employee version of Quit() is executed.
            quitter.Quit();

            // 🛑 Final pause so the console doesn't vanish instantly.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
