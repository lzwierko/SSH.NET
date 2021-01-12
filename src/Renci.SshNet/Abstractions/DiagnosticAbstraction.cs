using NLog;

namespace Renci.SshNet.Abstractions
{
    internal static class DiagnosticAbstraction
    {
        public static void Log(string text)
        {
            LogManager.GetLogger("SshNet").Trace(text);
            //#if FEATURE_DIAGNOSTICS_TRACESOURCE
            //            Loggging.TraceEvent(TraceEventType.Verbose, Thread.CurrentThread.ManagedThreadId, text);
            //#endif // FEATURE_DIAGNOSTICS_TRACESOURCE
        }
    }
}
