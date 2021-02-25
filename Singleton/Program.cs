using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramLogger.GetProgramLogger().addLogInfo("First log...");
            ProgramLogger.GetProgramLogger().addLogInfo("Second log...");
            ProgramLogger.GetProgramLogger().addLogInfo("Third log...");
            ProgramLogger.GetProgramLogger().showLogFile();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
