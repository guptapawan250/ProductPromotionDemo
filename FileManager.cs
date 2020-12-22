using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatementForPromotionEngine
{
    interface IFile
    {
        void LogIntoFile(string message);
    }
    public class FileManager : IFile
    {
        static int instanceCounter = 0;  
        private static FileManager singleInstance = null;  
        private static readonly object lockObject = new object();
        private FileManager()  
        {  
          instanceCounter++;  
      
        }

        public static FileManager SingleInstance  
        {  
          get  
          {  
            lock (lockObject)  
            {  
              if (singleInstance == null)  
              {
                  singleInstance = new FileManager();  
              }  
  
            }  
            return singleInstance;  
          }  
        }
        public void LogIntoFile(string message)  
        { 
            System.IO.File.WriteAllText("log.txt", message);
        } 
    }
}
