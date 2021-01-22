using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFileUpload.Shared;

namespace BlazorFileUpload.Server.Services
{
    public class ServerMessageLogger : IMessageLogger
    {
        public void WriteTrace(string msg)
        {
            Console.WriteLine($"Trace:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteTrace(string methodCallId, string msg)
        {
            Console.WriteLine($"({methodCallId}) Trace:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteDebug(string msg)
        {
            Console.WriteLine($"Debug:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteDebug(string methodCallId, string msg)
        {
            Console.WriteLine($"({methodCallId}) Debug:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteInfo(string msg)
        {
            Console.WriteLine($"Info:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteInfo(string methodCallId, string msg)
        {
            Console.WriteLine($"({methodCallId}) Info:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteError(string methodCallId, string msg)
        {
            Console.WriteLine($"({methodCallId}) Error:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteWarning(string msg)
        {
            Console.WriteLine($"Warning:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteWarning(string methodCallId, string msg)
        {
            Console.WriteLine($"({methodCallId}) Warning:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteError(string msg)
        {
            Console.WriteLine($"Error:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}");
        }

        public void WriteError(Exception exc)
        {
            Console.WriteLine($"Error:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {exc.Message}");
        }

        public void WriteError(string msg, Exception exc)
        {
            Console.WriteLine($"Error:{DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg} : {exc.Message}");
        }

        public void WriteError(string methodCallId, string msg, Exception exc)
        {
            Console.WriteLine($"({methodCallId}) {DateTime.Now:MM/dd/yyyy hh:mm:ss.fff tt} {msg}:{exc.Message}");
        }
    }
}
