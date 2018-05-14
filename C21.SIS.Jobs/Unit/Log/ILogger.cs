using System;

namespace C21.SIS.Jobs.Unit.Log
{
    public interface ILogger
    {
        void Debug(string msg);

        void Trace(string msg);

        void Info(string msg);

        void Warn(string msg);

        void Error(string msg);

        void Error(Exception ex);

        void Fatal(Exception ex);
    }
}