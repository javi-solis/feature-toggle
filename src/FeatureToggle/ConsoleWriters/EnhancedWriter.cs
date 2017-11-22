using FeatureToggle.Interfaces;
using System;

namespace FeatureToggle.ConsoleWriters
{
    public class EnhancedWriter : IConsoleWriter
    {
        public void WriteLine(string parameter)
        {
            Console.WriteLine($"Enhanced console write {parameter}");
        }
    }
}
