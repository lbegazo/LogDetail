using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDetail.JobLogger_LuisBegazo
{
    public interface ILogMessage
    {
        void LogMessage(int messageType, string message);        
    }
}
