using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDetail.JobLogger_LuisBegazo
{
    public class LogDataBase: ILogMessage
    {
        string connectionString = string.Empty;

        private SqlConnection GetConexion()
        {
            SqlConnection mycon = new SqlConnection(this.connectionString);
            return mycon;
        }

        public LogDataBase()
        {
            var cs = ConfigurationManager.AppSettings["default"];
            this.SetConnectionString(cs);
        }


        public void SetConnectionString(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void LogMessage(int messageType, string message)
        {
            SqlConnection connection = null;          

            try
            {
                using (connection = GetConexion())
                {
                    using (SqlCommand sqlcomm = new SqlCommand("LogValues_Insert", connection))
                    {
                        sqlcomm.CommandType = CommandType.StoredProcedure;
                        sqlcomm.CommandTimeout = int.MaxValue;                        
                        sqlcomm.Parameters.Add("@message", SqlDbType.VarChar, 8000).Value = message;
                        connection.Open();
                        sqlcomm.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }        
        }
    }
}
