using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UsbManagerDemo
{
    public class USBController
    {
        private static string tbText4;
        private static string usbGuardado;
        private static string usb;
        private static string decryp;

        static string mPath = Directory.GetCurrentDirectory();

        public void UsbController(string _usb)
        {
            usb = _usb;
        }

        public static void SecureKeyFileCheck()
        {
            if (!File.Exists(mPath + "\\SucureKey.txt"))
            {
                File.Create(mPath + "\\SucureKey.txt");
            }
        }

        public static void SetTextSecureKey(string data, string key)
        {
            //Console.WriteLine(ProcesadorID.GetProcesador());
            Console.WriteLine(MD5Generator.Encrypt(data, key));

            if (!File.Exists(mPath + "\\SucureKey.txt"))
            {
                File.Create(mPath + "\\SucureKey.txt");
            }
            else
            {
                TextWriter tw = new StreamWriter(mPath + "\\SucureKey.txt");
                decryp = MD5Generator.Encrypt(data, key);
                tw.WriteLine(MD5Generator.Encrypt(data, key));
                tw.Close();
            }
            
        }

        public static void GetTextSecureKey(string data, string key)
        {
            string decrypString = MD5Generator.Decrypt(data, key);
            Console.WriteLine(decrypString);
            
        }

        public static void ReadFileSecureKey()
        {
            //TextReader tr = new StreamReader(mPath + "\\SucureKey.txt");
            //usbGuardado = tr.ReadToEnd().ToString();
            //Console.WriteLine(tr.ReadToEnd().ToString());

            StreamReader sr = new StreamReader(mPath + "\\SucureKey.txt");
            {
                String line = sr.ReadToEnd();
                usbGuardado = line;
            }
        }

        public static string TextBox4
        {
            get 
            { 
                return tbText4; 
            }
            set
            {
                value = tbText4;
            }
        }

        public static string USB
        {
            get
            {
                return usb;
            }
            set 
            {
                value = usb;
            }
        }

        public static string USBGuardado
        {
            get
            {
                return usbGuardado;
            }
            set
            {
                value = usbGuardado;
            }
        }
    }
}
