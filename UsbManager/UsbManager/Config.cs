using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsbManagerDemo
{
    public partial class Config : Form
    {
        static string mPath = Directory.GetCurrentDirectory();

        public Config()
        {
            InitializeComponent();

            textBox1.Text = USBController.USB;

            //USBController.ReadFileSecureKey();
            //textBox3.Text = USBController.USBGuardado;
            //Console.WriteLine(USBController.USB);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // Guardar USB
        private void button2_Click(object sender, EventArgs e)
        {
            
            USBController.SetTextSecureKey(ProcesadorID.GetProcesador() + " " + USBController.USB + " " + textBox4.Text, textBox4.Text);
            //USBController.GetTextSecureKey("0S1eklsMbQOw+afCgNgbzFKScN1xR0rx2VkPr1N3tVljocCgiT7qDvklPZUCbsR8vElxh5+Y6s8xHzHh4gPhSw==", textBox4.Text);

            USBController.ReadFileSecureKey();
            textBox3.Text = USBController.USBGuardado;
            
        }
    }
}
