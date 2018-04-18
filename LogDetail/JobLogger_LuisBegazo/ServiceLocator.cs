using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDetail.JobLogger_LuisBegazo
{
    public class ServiceLocator
    {
        internal static T Find<T>() where T : class
        {
            if (typeof(T) == typeof(LogConsole))
                return new LogConsole() as T;
            if (typeof(T) == typeof(LogDataBase))
                return new LogDataBase() as T;
            if (typeof(T) == typeof(LogTextFile))
                return new LogTextFile() as T;

            throw new TypeLoadException("cannot find type " + typeof(T).Name);
        }
    }
}
