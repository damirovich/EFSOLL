using System;
using System.Management;

namespace _008ASPAdvanedTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.WriteToEventLog = false;

#pragma warning disable CA1416 // Проверка совместимости платформы
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectCollection objs = searcher.Get();
#pragma warning restore CA1416 // Проверка совместимости платформы

            foreach (ManagementObject mo in objs)
            {
#pragma warning disable CA1416 // Проверка совместимости платформы
                mo.Get();
#pragma warning restore CA1416 // Проверка совместимости платформы

                foreach (var prop in mo.Properties)
                {
#pragma warning disable CA1416 // Проверка совместимости платформы
                    Logger.Log($"{prop.Name} = {prop.Value}");
#pragma warning restore CA1416 // Проверка совместимости платформы
                }
            }
        }
    }
}
