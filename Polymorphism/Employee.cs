using System;   // 🌐 Needed for Console and other system utilities.

namespace QuittableDemoApp  // 📦 Same namespace so all types live together.
{
    // 🧑‍💼 Employee class from previous drill.
    // 👉 Now it *inherits* from IQuittable, meaning it must implement Quit().
    public class Employee : IQuittable
    {
        // 🔢 Unique identifier for the employee.
        public int Id { get; set; }

        // 📝 First name—nothing fancy, just informational.
        public string FirstName { get; set; }

        // 📝 Last name—to complete the identity.
        public string LastName { get; set; }

        // 🚪 Implementation of Quit() required by IQuittable.
        // 👉 Here we simply log a message, but in real systems this could
        // mean closing accounts, notifying HR, etc.
        public void Quit()
        {
            Console.WriteLine($"Employee {FirstName} {LastName} (ID: {Id}) has quit the company!");
        }
    }
}
