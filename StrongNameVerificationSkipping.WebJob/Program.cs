using System;
using Microsoft.Win32;
using StrongNameVerificationSkipping.DelayedSign;

namespace StrongNameVerificationskipping.WebJob
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
