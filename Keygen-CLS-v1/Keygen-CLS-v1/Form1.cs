using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygen_CLS_v1
{
    public partial class Form1 : Form
    {
        // user name + CrackS-Latinos
        List<int> listBytesInput = new List<int>();

        // md5 + nombre pc 
        List<int> listBytesConcat = new List<int>();

        public Form1()
        {
            InitializeComponent();

            // User Name PC 
            usrPC.Text = Environment.UserName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            xorInput1.Text = "";
            md5Out1.Text = "";

            if(txtName.Text != ""){

                // reset
                string concatName = " CrackS-Latinos";
                txtConcat.Text = concatName;

                // concat
                string concat = txtName.Text + txtConcat.Text;
                txtConcat.Text = concat;
                
                // xor input
                xorInput1.Text = generateXor(txtConcat.Text, 0x1E);

                // generate xor
                mMD5.m_byteInput = listToBytes(listBytesInput);
                //Console.WriteLine(mMD5.CalculateMD5Value(listToBytes(listBytesInput)));
                md5Out1.Text = mMD5.CalculateMD5Value(listToBytes(listBytesInput)).ToString();

                md5PC.Text = mMD5.CalculateMD5Value(listToBytes(listBytesInput)) + usrPC.Text;
                xorOut2.Text = generateXorMd5PC(md5PC.Text, 0x3C);

                // generate md5
                mMD5.m_byteInput = listToBytes(listBytesConcat);
                md5Out2.Text = mMD5.CalculateMD5Value(listToBytes(listBytesConcat)).ToString();

                // get md5
                string parse = md5Out2.Text;

                // parse
                var temporal = "";
                for (int m = 0; m < parse.Length; m++)
                {
                    if (parse[m] == 'F')
                    {
                        temporal += "T";

                    }else{

                        temporal += parse[m];
                    }
                }


                #region Parse
                
                

                // parse
                var salida = "";
                for (int p = 0; p < temporal.Length; p++)
                {
                    if (p == 7)
                    {
                        salida += "C";
                    }
                    else
                    {
                        salida += temporal[p];
                    }

                }

                // parse
                var salida2 = "";
                for (int f = 0; f < salida.Length; f++)
                {
                    if (f == 15)
                    {
                        salida2 += "L";
                    }
                    else
                    {
                        salida2 += salida[f];
                    }

                }

                // parse
                var salida3 = "";
                for (int a = 0; a < salida2.Length; a++)
                {
                    if (a == 23)
                    {
                        salida3 += "S";
                    }
                    else
                    {
                        salida3 += salida2[a];
                    }

                }

                #endregion

                // add 
                txtSerial.Text = salida3;
            }
            else
            {
                MessageBox.Show("Tienes que poner un nombre", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        // Xor concat name + CrackS-Latinos
        private string generateXor(string data, int key)
        {
            // reset
            var tmp = "";
            listBytesInput.Clear();

            for (int i = 0; i < data.Length; i++)
            {
                // XOR
                //int s = (int)data[i] ^ key;

                // to string 
                tmp += ((int)data[i] ^ key) + " ";

                // add list
                listBytesInput.Add((int)data[i] ^ key);

            }

            return tmp;
        }


        // Xor md5 + name pc
        private string generateXorMd5PC(string data, int key)
        {
            // reset
            var tmp = "";
            listBytesConcat.Clear();

            for (int i = 0; i < 1024; i++)
            {
                if (i <= data.Length -1)
                {
                    // test box
                    tmp += ((int)data[i] ^ key) + " ";

                    // add list
                    listBytesConcat.Add((int)data[i] ^ key);
                }
                else
                {
                    listBytesConcat.Add(0x00);
                }
                
            }

            return tmp;
        }


        // listToArray
        private byte[] listToBytes(List<int> list)
        {
            byte[] tmpList = new byte[list.Count];

            for (int i = 0; i < list.Count; i++)
			{
			    tmpList[i] = (byte)list[i];
			}

            return tmpList;
        }

    }
}
