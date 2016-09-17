using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.Management;

namespace UsbManagerDemo
{
    public static class ProcesadorID
    {
        public static string GetProcesador()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            return cpuInfo;
        }
    }
}
