using StrongNameVerificationSkipping.DelayedSign;
using System;

namespace StrongNameVerificationSkipping.WebJob64
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Is64Bit: {Environment.Is64BitProcess}");

            StaticFunction.Example();

            return;
        }
    }
}
