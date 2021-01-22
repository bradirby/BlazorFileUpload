using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFileUpload.Shared
{
    public interface IMessageLogger
    {

        /// <summary>
        /// Logger.WriteTrace($"{System.Reflection.MethodBase.GetCurrentMethod().Name} starting");
        /// </summary>
        public void WriteTrace(string msg);
        public void WriteTrace(string methodCallId, string msg);

        public void WriteDebug(string msg);
        public void WriteDebug(string methodCallId, string msg);

        public void WriteInfo(string msg);
        public void WriteInfo(string methodCallId, string msg);

        public void WriteError(string msg);
        public void WriteError(string methodCallId, string msg);

        public void WriteWarning(string msg);
        public void WriteWarning(string methodCallId, string msg);

        public void WriteError(Exception exc);
        public void WriteError(string methodCallId, Exception exc);

        public void WriteError(string methodCallId, string msg, Exception exc);
    }
}
