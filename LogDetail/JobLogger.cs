using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LogDetail
{

    /*
     * 
     * Luis begazo
     Comments and feedback
     
     *  Compilation errors:
            Use of unassigned local variable 't' and 'l'.            
            The parameter name 'message' is a duplicate.
            The operator '&&' can not be applied to operands of type 'string' and 'bool'.
     
     *  The variable _initialized is never used.
     
     *  The variables: _logToFile, _logToConsole, _logMessage, _logWarning, _logError, LogToDatabase are static variables 
        so they share their values in all instances of the class JobLogger, if the process execute more times, the variables will have the same value of the previous process.
     
     *  After the reason above, LogMessage method must not be a static method because in a static method all fields must also be static. 
      
     *  The constructor has many parameters, you should only include parameters that are required for it to be a proper object.
     
     *  Database,         
        Sqlcommand needs to set a connection.
        The query of the Sqlcommand needs to specify the keyword "values"
        SqlConnection and Sqlcommand need to use "using" statement because ensures that Dispose is called even if an exception occurs while you are calling methods on the object
        To protect our system from SQL injection, we can use SQL parameters. The SQL engine checks each parameter to ensure that it is correct for its column.
        Some connection specifications are below(*)
     
     *  File: 
        We can create a variable to get the key "LogFileDirectory" from the config file just once time.     
        File name can not use invalid characters(DateTime.Now.ToShortDateString()) 
        WriteAllText overwrite the old text you need to use File.AppendAllText to return all data to txt file
        Some path specifications are below(*)
        
     */

    public class JobLogger
    {

        private static bool _logToFile;
        private static bool _logToConsole;
        private static bool _logMessage;
        private static bool _logWarning;
        private static bool _logError;
        private static bool LogToDatabase;
        private bool _initialized;

        public JobLogger(bool logToFile, bool logToConsole, bool logToDatabase, 
                         bool logMessage, bool logWarning, bool logError)
        {
            _logError = logError;
            _logMessage = logMessage;
            _logWarning = logWarning;
            LogToDatabase = logToDatabase;
            _logToFile = logToFile;
            _logToConsole = logToConsole;
        }

        public static void LogMessage(string message, bool blnmessage, bool warning, bool error)
        {
            message.Trim();

            /*
             string.IsNullOrEmpty detects both conditions at the same time
             Despite string.IsNullOrEmpty has a middle performance, using string.IsNullOrEmpty is clearer
             */
            if (message == null || message.Length == 0)
            {
                return;
            }
            if (!_logToConsole && !_logToFile && !LogToDatabase)
            {
                throw new Exception("Invalid configuration");
            }

            if ((!_logError && !_logMessage && !_logWarning) || (!blnmessage && !warning && !error))
            {
                throw new Exception("Error or Warning or Message must bespecified");
            }

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);
            /*
             Open connections as late as possible
             */
            connection.Open();
            int t = 0;
            if (blnmessage && _logMessage)
            {
                t = 1;
            }
            if (error && _logError)
            {
                t = 2;
            }
            if (warning && _logWarning)
            {
                t = 3;
            }

            //connection.Open();
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("Insert into LogValues values('" + message + "'," + t.ToString() + ")");
            //System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand("Insert into LogValues(Message,TypeMessage) values('" + message + "'," + t.ToString() + ")");
            //CommandType.StoredProcedure is faster than CommandType.Text, Stored Procedure is a group of precompiled Transact SQL statement into a single execution plan.
            //command.Connection = connection;
            command.ExecuteNonQuery();

            /*
              Close the connection as soon as possible
              The connection itself is returned to the connection pool. Connections are a limited and relatively expensive resource
             */
            string l = string.Empty;

            if (!System.IO.File.Exists(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToShortDateString() + ".txt"))
            //if (System.IO.File.Exists(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToShortDateString() + ".txt"))
            {
                /*
                We must not read the text of the file because the line above said the file does not exist 
                */
                l = System.IO.File.ReadAllText(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToShortDateString() + ".txt");
            }
            //else
            //{
            //    FileStream filestream = new FileStream(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToString("yyyyMMdd") + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            //    filestream.Close();
            //}
            if (error && _logError)
            {
                l = l + DateTime.Now.ToShortDateString() + message;
            }
            if (warning && _logWarning)
            {
                l = l + DateTime.Now.ToShortDateString() + message;
            }
            if (blnmessage && _logMessage)
            {
                l = l + DateTime.Now.ToShortDateString() + message;
            }

            System.IO.File.WriteAllText(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToShortDateString() + ".txt", l);
            //System.IO.File.WriteAllText(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"] + "LogFile" + DateTime.Now.ToString("yyyyMMdd") + ".txt", l);

            if (error && _logError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (warning && _logWarning)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (blnmessage && _logMessage)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine(DateTime.Now.ToShortDateString() + message);
        }
    }

}