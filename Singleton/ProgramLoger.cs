using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class ProgramLogger
    {
        private static  ProgramLogger programLoggeer;
        private static string logFile = "This is log file. \n\n";
        static object locker = new object();

        
        public  static ProgramLogger GetProgramLogger() 
        {
            lock (locker)

            if (programLoggeer == null)
            {
                programLoggeer = new ProgramLogger();
            }
            return programLoggeer;
        }

        private ProgramLogger()
        {

        }

        public void addLogInfo(string logInfo)
        {
            logFile += logInfo + "\n";
        }


        public void showLogFile()
        {
            Console.WriteLine(logFile);
        }

    }
}
