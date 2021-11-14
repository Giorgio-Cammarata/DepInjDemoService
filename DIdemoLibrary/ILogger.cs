using System;

namespace DIdemoLibrary
{
    public interface ILogger
    {
        void LogInfo(string info);
        void LogError(string error);
        void LogError(Exception exception);
    }
}
