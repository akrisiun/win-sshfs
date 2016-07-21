#region

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

#endregion

namespace Sshfs
{
    internal static class Program
    {
        static SftpManagerApplication app;

        /// <summary>
        ///   The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(params string[] args )
        {

#if DEBUG
            Debug.AutoFlush = true;
            Debug.Listeners.Clear();
            //Debug.Listeners.Add(new DelimitedListTraceListener(String.Format("{0}\\log{1:yyyy-MM-dd-HH-mm-ss}.txt",Environment.CurrentDirectory,DateTime.Now), "debug"));
            Debug.Listeners.Add(new DelimitedListTraceListener(Environment.CurrentDirectory+"\\last.log", "debug"));
#endif
            app = new SftpManagerApplication();
            //app.First
            app.UnhandledException += app_UnhandledException;
            app.Shutdown += app_Shutdown;
            app.Run(args);
        }

        static void app_Shutdown(object sender, EventArgs e)
        {
            Debugger.Log(0, "", "Shutdown");
        }

        static void app_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
        {
            var ex = e.Exception;
            Debugger.Log(0, "UnhandledException", ex.Message);
            Debugger.Log(0, "UnhandledException", ex.StackTrace);
            MessageBox.Show(e.Exception.Message);
        }
    }
}