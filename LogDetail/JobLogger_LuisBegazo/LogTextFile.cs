using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDetail.JobLogger_LuisBegazo
{
    public class LogTextFile : ILogMessage
    {
        private string GetPath()
        {
            string path = ConfigurationManager.AppSettings["LogFileDirectory"];
            return path;
        }

        public void LogMessage(int messageType, string message)
        {
            string allPath = string.Empty;
            string path = string.Empty;

            try
            {
                path = GetPath();
                allPath = String.Concat(path, "LogFile", DateTime.Now.ToString("yyyyMMdd"), ".txt");
                if (!System.IO.File.Exists(allPath))
                {
                    FileStream filestream = new FileStream(allPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                    filestream.Close();
                }

                string[] start = { message + "\n" };
                File.AppendAllLines(allPath, start);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
