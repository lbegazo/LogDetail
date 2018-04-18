using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDetail.JobLogger_LuisBegazo
{
    public class JobLogger
    {
        private ILogMessage _logManager;

        private ILogMessage LogManager
        {
            get
            {
                if (this._logManager == null)
                {
                    this._logManager = ServiceLocator.Find<LogConsole>();
                }

                return _logManager;

            }
            set { _logManager = value; }
        }

        public bool LogToFile { get; set; }

        public bool LogToConsole { get; set; }

        public bool LogToDataBase{ get; set; }

        public bool LogMsg { get; set; }

        public bool LogWarning { get; set; }

        public bool LogError { get; set; }

        public bool LogMessage(int typeMessage, string message)
        {
            string msj = GetMessage(typeMessage, message);
            if (Validate(typeMessage, message))
            {
                if (LogToDataBase)
                {                    
                    LogManager = JobLogger_LuisBegazo.ServiceLocator.Find<JobLogger_LuisBegazo.LogDataBase>();
                    LogManager.LogMessage(typeMessage, msj);
                }
                if (LogToConsole)
                {                    
                    LogManager = JobLogger_LuisBegazo.ServiceLocator.Find<JobLogger_LuisBegazo.LogConsole>();
                    LogManager.LogMessage(typeMessage, msj);
                }
                if (LogToFile)
                {
                    LogManager = JobLogger_LuisBegazo.ServiceLocator.Find<JobLogger_LuisBegazo.LogTextFile>();
                    LogManager.LogMessage(typeMessage, msj);
                }
                return true;
            }
            else
                return false;
        }

        private bool Validate(int typeMessage, string message)
        {            
            if (!LogToConsole && !LogToFile && !LogToDataBase)
            {
                throw new Exception("Invalid configuration");
            }

            if ((!LogMsg && !LogError && !LogWarning))
            {
                throw new Exception("Log message type must be specified");
            }

            if (typeMessage.Equals(0))
            {
                throw new Exception("Message type must be specified");
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new Exception("Message must be specified");
            }

            if (LogMsg && typeMessage.Equals((int)MessageType.message))
            {
                return true;
            }
            if (LogError && typeMessage.Equals((int)MessageType.error))
            {
                return true;
            }
            if (LogWarning && typeMessage.Equals((int)MessageType.warning))
            {
                return true;
            }
            return false;
        }

        private string GetMessage(int typeMessage, string message)
        {
            return string.Concat(DateTime.Now.ToShortDateString(), " ", typeMessage, " ", message);
        }
    }
}
