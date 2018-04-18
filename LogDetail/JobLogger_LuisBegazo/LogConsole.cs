using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDetail.JobLogger_LuisBegazo
{
    public class LogConsole: ILogMessage
    {
        public void LogMessage(int messageType, string message)
        {
            switch (messageType)
            {
                case (int)MessageType.error:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    break;
                case (int)MessageType.warning:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    break;
                case (int)MessageType.message:
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
                default:
                    break;
            }
            
            Console.WriteLine(message);
        }
    }
}
