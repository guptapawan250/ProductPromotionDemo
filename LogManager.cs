using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatementForPromotionEngine
{
    interface Ilogger
    {
        void Info(string message);
        void Error(string message);
        void Warning(string message);
        void Debug(string message);
    }


    public sealed class LogManager : Ilogger
    {
        static int instanceCounter = 0;  
        private static LogManager singleInstance = null;  
        private static readonly object lockObject = new object();

        FileManager fileManager  = FileManager.SingleInstance;  
     
        private LogManager()  
        {  
          instanceCounter++;  
          
        }

        public static LogManager SingleInstance  
        {  
          get  
          {  
            lock (lockObject)  
            {  
              if (singleInstance == null)  
              {
                  singleInstance = new LogManager();  
              }  
  
            }  
            return singleInstance;  
          }  
        }
        public void Info(string message)
        {
            fileManager.LogIntoFile("Info" + message);
        }

        public void Error(string message)
        {
            fileManager.LogIntoFile("Error" + message);
        }

        public void Warning(string message)
        {
            fileManager.LogIntoFile("Warning" + message);
        }

        public void Debug(string message)
        {
            fileManager.LogIntoFile("Debug" + message);
        }     
    }
}
