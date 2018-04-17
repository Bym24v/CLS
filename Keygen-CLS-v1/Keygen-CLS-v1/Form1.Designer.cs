namespace Keygen_CLS_v1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConcat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.xorInput1 = new System.Windows.Forms.TextBox();
            this.md5Out1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.md5PC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xorOut2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.md5Out2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usrPC = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 20);
            this.txtName.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Concat:";
            // 
            // txtConcat
            // 
            this.txtConcat.Location = new System.Drawing.Point(68, 42);
            this.txtConcat.Name = "txtConcat";
            this.txtConcat.ReadOnly = true;
            this.txtConcat.Size = new System.Drawing.Size(272, 20);
            this.txtConcat.TabIndex = 21;
            this.txtConcat.Text = "CrackS-Latinos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "XOR";
            // 
            // xorInput1
            // 
            this.xorInput1.Location = new System.Drawing.Point(16, 134);
            this.xorInput1.Multiline = true;
            this.xorInput1.Name = "xorInput1";
            this.xorInput1.Size = new System.Drawing.Size(324, 46);
            this.xorInput1.TabIndex = 24;
            // 
            // md5Out1
            // 
            this.md5Out1.Location = new System.Drawing.Point(16, 207);
            this.md5Out1.Name = "md5Out1";
            this.md5Out1.Size = new System.Drawing.Size(324, 20);
            this.md5Out1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "MD5";
            // 
            // md5PC
            // 
            this.md5PC.Location = new System.Drawing.Point(16, 257);
            this.md5PC.Name = "md5PC";
            this.md5PC.Size = new System.Drawing.Size(324, 20);
            this.md5PC.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "MD5 + USER PC";
            // 
            // xorOut2
            // 
            this.xorOut2.Location = new System.Drawing.Point(16, 307);
            this.xorOut2.Multiline = true;
            this.xorOut2.Name = "xorOut2";
            this.xorOut2.Size = new System.Drawing.Size(324, 44);
            this.xorOut2.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "XOR";
            // 
            // md5Out2
            // 
            this.md5Out2.Location = new System.Drawing.Point(16, 379);
            this.md5Out2.Name = "md5Out2";
            this.md5Out2.Size = new System.Drawing.Size(324, 20);
            this.md5Out2.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "MD5 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "User PC:";
            // 
            // usrPC
            // 
            this.usrPC.Location = new System.Drawing.Point(68, 68);
            this.usrPC.Name = "usrPC";
            this.usrPC.ReadOnly = true;
            this.usrPC.Size = new System.Drawing.Size(272, 20);
            this.usrPC.TabIndex = 36;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(16, 446);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(324, 20);
            this.txtSerial.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Serial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 541);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.md5Out2);
            this.Controls.Add(this.xorInput1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.md5Out1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.md5PC);
            this.Controls.Add(this.xorOut2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.usrPC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtConcat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Keygen CLS v0.1 | @Bym24v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConcat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox xorInput1;
        private System.Windows.Forms.TextBox md5Out1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox md5PC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xorOut2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox md5Out2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usrPC;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label6;
    }
}

