using System;
using NLog;

namespace C21.SIS.Jobs.Unit.Log
{
    public class NLogger : ILogger
    {
        private readonly Logger _logger;

        public NLogger(Logger logger)
        {
            _logger = logger;
        }

        public void Debug(string msg)
        {
            _logger.Debug(msg);
        }

        public void Info(string msg)
        {
            _logger.Info(msg);
        }

        public void Warn(string msg)
        {
            _logger.Warn(msg);
        }

        public void Error(string msg)
        {
            _logger.Error(msg);
        }

        public void Error(Exception ex)
        {
            _logger.Error(ex);
        }

        public void Fatal(Exception ex)
        {
            _logger.Fatal(ex);
        }

        public void Trace(string msg)
        {
            _logger.Trace(msg);
        }
    }
}