using FeatureToggle.Config;
using FeatureToggle.ConsoleWriters;
using FeatureToggle.Interfaces;
using System;
using System.Threading;

namespace FeatureToggle
{
    class Program
    {        
        static void Main(string[] args)
        {
            IConsoleWriter consoleWriter = null;
            IFeatureToggleConfig featureToggleConfig = new FeatureToggleConfig();            
            if (featureToggleConfig.IsEnhancedWriterEnabled)
            {
                consoleWriter = new EnhancedWriter();
            }
            else
            {
                consoleWriter = new TraditionalWriter();
            }

            Console.WriteLine("Press ESC to stop");
            do
            {
                int i = 0;
                while (!Console.KeyAvailable)
                {
                    consoleWriter.WriteLine(i.ToString());
                    Thread.Sleep(2000);
                    i++;
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
