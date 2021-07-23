using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008ASPAdvanedTask1
{
    internal class Logger
    {
        private static bool _initialized = false;
        private static EventLog _eventLog = null;

        public static bool WriteToEventLog
        {
            get { return _eventLog != null; }
            set
            {
                if (value)
                {
                    if (_eventLog == null)
                    {
#pragma warning disable CA1416 // Проверка совместимости платформы
                        _eventLog = new EventLog
                        {
                            Source = "Application"
                        };
#pragma warning restore CA1416 // Проверка совместимости платформы

                    }
                }
                else
                {
                    _eventLog?.Dispose();
                    _eventLog = null;
                }
            }
        }

        public static void Log(string message)
        {
            if (!_initialized)
            {
                Initialize();
                _initialized = true;
            }

            Trace.WriteLine(message);
#pragma warning disable CA1416 // Проверка совместимости платформы
            _eventLog?.WriteEntry(message);
#pragma warning restore CA1416 // Проверка совместимости платформы
        }

        private static void Initialize()
        {
            string loggingDirectory = GetLoggingPath();
            var path = loggingDirectory + "\\log.txt";
            var textListener = new TextWriterTraceListener(path);

            Trace.Listeners.Add(textListener);

            var consoleListener = new TextWriterTraceListener(Console.Out);
            Trace.Listeners.Add(consoleListener);

            Trace.AutoFlush = true;
        }

        private static string GetLoggingPath()
        {
#pragma warning disable CA1416 // Проверка совместимости платформы
            using (var registry = Registry.CurrentUser.OpenSubKey(@"Software\MyConsoleApp\"))
#pragma warning restore CA1416 // Проверка совместимости платформы
            {
#pragma warning disable CA1416 // Проверка совместимости платформы
                var path = registry?.GetValue("LoggingPath").ToString();
#pragma warning restore CA1416 // Проверка совместимости платформы
                if (!string.IsNullOrEmpty(path))
                {
                    return path;
                }
            }

            var appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var logFolderPath = Path.Combine(appData, "MyConsole_NetFramework");
            Directory.CreateDirectory(logFolderPath);
            return logFolderPath;
        }
    }
}
