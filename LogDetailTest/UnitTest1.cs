using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogDetail.JobLogger_LuisBegazo;

namespace LogDetailTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestSuccess()
        {
            LogDetail.JobLogger_LuisBegazo.JobLogger job = new LogDetail.JobLogger_LuisBegazo.JobLogger();

            job.LogToDataBase = true;
            job.LogToConsole = true;
            job.LogToFile = false;

            job.LogMsg = false;
            job.LogError = true;
            job.LogWarning = false;

            Assert.IsTrue(job.LogMessage((int)(MessageType.error), "Error message"));
        }

        
       //[ExpectedException(typeof(Exception), "Invalid configuration")]
       [TestMethod]
       public void TestDidNotSaved()
       {
           LogDetail.JobLogger_LuisBegazo.JobLogger job = new LogDetail.JobLogger_LuisBegazo.JobLogger();

           job.LogToDataBase = true;
           job.LogToConsole = true;
           job.LogToFile = true;

           job.LogMsg = true;
           job.LogError = false;
           job.LogWarning = false;


           Assert.IsFalse(job.LogMessage((int)(MessageType.error), "Error message"));
       }

       [TestMethod]
       [ExpectedException(typeof(Exception), "Invalid configuration 2")]
       public void TestInvalidConfiguration()
       {
           LogDetail.JobLogger_LuisBegazo.JobLogger job = new LogDetail.JobLogger_LuisBegazo.JobLogger();

           job.LogToDataBase = true;
           job.LogToConsole = true;
           job.LogToFile = true;

           job.LogMsg = false;
           job.LogError = false;
           job.LogWarning = false;

           job.LogMessage((int)(MessageType.error), "Error message");
           Assert.Fail();
       }
        /*
       [TestMethod]
       [ExpectedException(typeof(Exception), "Invalid configuration")]
       public void TestException()
       {
           LogDetail.JobLoggerNew job = new LogDetail.JobLoggerNew();

           job.LogToDatabase = false;
           job.LogToConsole = false;
           job.LogToFile = false;

           job.LogMessageBln = true;
           job.LogError = false;
           job.LogWarning = false;

           job.LogMessage(1, "Error message");
           //Assert.Fail();
       }
        */
    }
}
