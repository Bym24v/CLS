
namespace UsbManagerDemo
{
    using System;
    using System.Windows.Forms;
    using iTuner;
    using System.Diagnostics;
    using System.IO;

    public partial class MainForm : Form
	{
		private static readonly string CR = Environment.NewLine;
        //static string mPath = Directory.GetCurrentDirectory();

		private UsbManager manager;

        private bool loginLock = false;

        string Device;

        USBController myUsb = new USBController();

		public MainForm ()
		{
			InitializeComponent();
            
            timer1.Start();

			manager = new UsbManager();
			UsbDiskCollection disks = manager.GetAvailableDisks();

			textBox.AppendText(CR);
			textBox.AppendText("Available USB disks" + CR);

			foreach (UsbDisk disk in disks)
			{
				textBox.AppendText(disk.ToString() + CR);
                textBox1.Text = disk.ToString();
                Device = disk.Model.ToString();
                myUsb.UsbController(Device);

                //TextWriter tw = new StreamWriter(mPath + "\\SucureKey.txt");
                //tw.WriteLine(Device);
                //tw.Close();
			}

			textBox.AppendText(CR);

			manager.StateChanged += new UsbStateChangedEventHandler(DoStateChanged);

            //if (!File.Exists(mPath + "\\SucureKey.txt"))
            //{
            //    File.Create(mPath + "\\SucureKey.txt");
            //    //TextWriter tw = new StreamWriter(mPath + "\\SucureKey.txt");
            //    //tw.WriteLine("Start Code: 23423902384023423852385203803849");
            //    //tw.Close();
            //}
            //else if (File.Exists(mPath + "\\SucureKey.txt"))
            //{
            //    TextWriter tw = new StreamWriter(mPath + "\\SucureKey.txt");
            //    tw.WriteLine("Code: 23423902384023423852385203803849");
            //    tw.Close();
            //}

            //Start();

            USBController.SecureKeyFileCheck();
            
		}


		private void DoStateChanged (UsbStateChangedEventArgs e)
		{
			textBox.AppendText(e.State + " " + e.Disk.ToString() + CR);
            //Console.WriteLine(e.State + " " + e.Disk.ToString());
            textBox1.Text = e.Disk.Model;
            Device = e.Disk.Model;
            myUsb.UsbController(Device);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine(Device);

            if (Device == "Kingston DataTraveler 3.0 USB Device")
            {
                Console.WriteLine("Conectado!!");
                Update();
            }
            else
            {
                Console.WriteLine("No Conectado!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "123" && Device == "Kingston DataTraveler 3.0 USB Device")
            {
                textBox2.Text = "";
                loginLock = true;
                checkBox2.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
                loginLock = false;
            }
        }


        void Update()
        {
            if (checkBox2.Checked == true && loginLock == true)
            {
                 ///checkBox1.Enabled = true;
                Login();
                Console.WriteLine("Bloqueado");
            }
            else
            {  
                Console.WriteLine("Debloqueado");
            }

        }

        void Login()
        {

            Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
            checkBox2.Checked = false;
            checkBox2.Enabled = false;
            loginLock = false;
        }

        private void configToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.Show();
        }
    }
}
