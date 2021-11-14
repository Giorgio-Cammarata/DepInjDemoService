using DIdemoLibrary;
using System;
using System.Diagnostics;

namespace TestDIdemo.UnitTests
{
    public class TraceLogger : ILogger
    {
        public void LogError(Exception exception)
        {
            LogError(exception.Message);
        }

        public void LogError(string error)
        {
            Trace.TraceError(error);
        }        

        public void LogInfo(string info)
        {
            Trace.TraceInformation(info);
        }
    }
}
