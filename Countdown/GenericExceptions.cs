using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// Provides static methods for handling exceptions thrown by the application.
/// </summary>
public static class GenericExceptions
{
    /// <summary>
    /// Sets the application to throw unhandled exceptions and direct them toward the appropriate method.
    /// </summary>
    public static void InitializeExceptions()
    {
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException);
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GenericExceptions.UnhandledException);
    }

    public static void UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        GenericExceptions.LogException((Exception)e.ExceptionObject);
    }

    /// <summary>
    /// Logs the specified exception to the specified log file and provides the option to notify the user of the exception.
    /// </summary>
    /// <param name="ex">The exception that has occurred.</param>
    public static void LogException(Exception ex)
    {
        GenericExceptions.LogException(ex, Application.StartupPath + "\\" + Application.ProductName + ".err", false);
    }

    /// <summary>
    /// Logs the specified exception to the specified log file and provides the option to notify the user of the exception.
    /// </summary>
    /// <param name="ex">The exception that has occurred.</param>
    /// <param name="filename">The file that the exception information should be written to.</param>
    public static void LogException(Exception ex, string filename)
    {
        GenericExceptions.LogException(ex, filename, false);
    }

    /// <summary>
    /// Logs the specified exception to the specified log file and provides the option to notify the user of the exception.
    /// </summary>
    /// <param name="ex">The exception that has occurred.</param>
    /// <param name="filename">The file that the exception information should be written to.</param>
    /// <param name="notify">If a dialog should be shown to notify the user of the exception.</param>
    public static void LogException(Exception ex, string filename, bool notify)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(DateTime.Now.ToString() + Environment.NewLine);
        string[] message = ex.Message.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string s in message)
            sb.Append(s + Environment.NewLine);
        string[] stack = ex.StackTrace.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string s in stack)
            sb.Append(s + Environment.NewLine);
        sb.Append(Environment.NewLine);
        File.AppendAllText(filename, sb.ToString());
        if (notify)
            MessageBox.Show(ex.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}