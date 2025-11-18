using System;   // 🌐 Pulling in System so we can use Console and other essentials.

namespace MathDemoApp   // 🏷️ A cozy namespace to wrap our application.
{
    // 🎯 This class will hold our magical math method.
    class MathOperations
    {
        // 🔧 A void method that takes two integers.
        // 👉 It performs a math operation on the first integer
        // 👉 and simply displays the second integer.
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // 🧮 Let's do a simple math operation on the first number—double it!
            int result = firstNumber * 2;

            // 🗣️ Announce the result of the math operation!
            Console.WriteLine($"Math result (first number doubled): {result}");

            // 👀 Then also display the second integer as required.
            Console.WriteLine($"Second number passed in: {secondNumber}");
        }
    }

    // 🎬 The main entry point of the entire application.
    class Program
    {
        static void Main(string[] args)
        {
            // 🏗️ Step 1: Create (instantiate) our MathOperations class.
            MathOperations ops = new MathOperations();

            // 🔊 Step 2: Call the method normally by passing two numbers.
            ops.ProcessNumbers(5, 10);

            // 🎯 Step 3: Call the method *again*, but this time by naming parameters.
            ops.ProcessNumbers(firstNumber: 7, secondNumber: 21);

            // 🧘 Optional: Freeze the console so it doesn’t disappear instantly.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
