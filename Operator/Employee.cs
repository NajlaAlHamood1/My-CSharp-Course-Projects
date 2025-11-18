using System;   // 🌍 Standard library import so we can use system-level types.

namespace EmployeeComparisonApp   // 🧱 Our small universe where Employee lives.
{
    // 🧑‍💼 The Employee class represents a worker with an Id and name fields.
    public class Employee
    {
        // 🔢 A unique numeric identifier for each employee.
        public int Id { get; set; }

        // 📝 First name field—keeps things personal.
        public string FirstName { get; set; }

        // 📝 Last name field—completes the identity.
        public string LastName { get; set; }

        // ⚖️ Overloading the equality operator (==).
        // 🎯 Purpose: Employees are equal if—and only if—their Id values match.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // 🛡 Handling null checks: crucial so we don’t crash the app.
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // 🎯 Final check: Compare the Ids.
            return emp1.Id == emp2.Id;
        }

        // ❗ The inequality operator must be overloaded as well—it's a requirement.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);   // 👈 Simply invert the == logic.
        }

        // 🧠 Good practice: override Equals() when overloading == to maintain consistency.
        public override bool Equals(object obj)
        {
            var other = obj as Employee;
            if (other == null) return false;
            return this.Id == other.Id;
        }

        // 🏷️ Also override GetHashCode() to match the Equals() logic.
        public override int GetHashCode()
        {
            return Id.GetHashCode(); // 🌀 Uses the integer Id to generate a hash.
        }
    }
}
