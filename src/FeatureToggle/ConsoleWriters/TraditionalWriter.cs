using FeatureToggle.Interfaces;
using System;

namespace FeatureToggle.ConsoleWriters
{
    class TraditionalWriter : IConsoleWriter
    {
        public void WriteLine(string parameter)
        {
            Console.WriteLine(String.Format("Traditional console write {0}", parameter));
        }
    }
}
