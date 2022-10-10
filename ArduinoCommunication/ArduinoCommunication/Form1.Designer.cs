namespace ArduinoCommunication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sendserial = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_cmdserial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.btn_connectserial = new System.Windows.Forms.Button();
            this.cmb_serial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sendbluetooth = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_cmdbluetooth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bluetooth = new System.Windows.Forms.TextBox();
            this.btn_connectbluetooth = new System.Windows.Forms.Button();
            this.cmb_bluetooth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_sendwifi = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_cmdwifi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_wifi = new System.Windows.Forms.TextBox();
            this.btn_connectwifi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sendserial);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_cmdserial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_serial);
            this.groupBox1.Controls.Add(this.btn_connectserial);
            this.groupBox1.Controls.Add(this.cmb_serial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial";
            // 
            // btn_sendserial
            // 
            this.btn_sendserial.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sendserial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendserial.Location = new System.Drawing.Point(201, 428);
            this.btn_sendserial.Name = "btn_sendserial";
            this.btn_sendserial.Size = new System.Drawing.Size(135, 40);
            this.btn_sendserial.TabIndex = 11;
            this.btn_sendserial.Text = "Send command";
            this.btn_sendserial.UseVisualStyleBackColor = false;
            this.btn_sendserial.Click += new System.EventHandler(this.Btn_sendserial_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(104, 508);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Disconnected";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Statut :";
            // 
            // cmb_cmdserial
            // 
            this.cmb_cmdserial.FormattingEnabled = true;
            this.cmb_cmdserial.Items.AddRange(new object[] {
            "on",
            "off"});
            this.cmb_cmdserial.Location = new System.Drawing.Point(23, 384);
            this.cmb_cmdserial.Name = "cmb_cmdserial";
            this.cmb_cmdserial.Size = new System.Drawing.Size(313, 38);
            this.cmb_cmdserial.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "input command :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "received data :";
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(23, 117);
            this.txt_serial.Multiline = true;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_serial.Size = new System.Drawing.Size(313, 224);
            this.txt_serial.TabIndex = 5;
            this.txt_serial.TextChanged += new System.EventHandler(this.Txt_serial_TextChanged);
            // 
            // btn_connectserial
            // 
            this.btn_connectserial.BackColor = System.Drawing.SystemColors.Control;
            this.btn_connectserial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connectserial.Location = new System.Drawing.Point(254, 34);
            this.btn_connectserial.Name = "btn_connectserial";
            this.btn_connectserial.Size = new System.Drawing.Size(82, 40);
            this.btn_connectserial.TabIndex = 4;
            this.btn_connectserial.Text = "Connect";
            this.btn_connectserial.UseVisualStyleBackColor = false;
            this.btn_connectserial.Click += new System.EventHandler(this.Btn_connectserial_Click);
            // 
            // cmb_serial
            // 
            this.cmb_serial.FormattingEnabled = true;
            this.cmb_serial.Location = new System.Drawing.Point(80, 34);
            this.cmb_serial.Name = "cmb_serial";
            this.cmb_serial.Size = new System.Drawing.Size(168, 38);
            this.cmb_serial.TabIndex = 3;
            this.cmb_serial.SelectedIndexChanged += new System.EventHandler(this.Cmb_serial_SelectedIndexChanged);
            this.cmb_serial.Click += new System.EventHandler(this.Cmb_serial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "port :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sendbluetooth);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmb_cmdbluetooth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_bluetooth);
            this.groupBox2.Controls.Add(this.btn_connectbluetooth);
            this.groupBox2.Controls.Add(this.cmb_bluetooth);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(433, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 573);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bluetooth";
            // 
            // btn_sendbluetooth
            // 
            this.btn_sendbluetooth.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sendbluetooth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendbluetooth.Location = new System.Drawing.Point(192, 430);
            this.btn_sendbluetooth.Name = "btn_sendbluetooth";
            this.btn_sendbluetooth.Size = new System.Drawing.Size(135, 40);
            this.btn_sendbluetooth.TabIndex = 12;
            this.btn_sendbluetooth.Text = "Send command";
            this.btn_sendbluetooth.UseVisualStyleBackColor = false;
            this.btn_sendbluetooth.Click += new System.EventHandler(this.Btn_sendbluetooth_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(110, 508);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 30);
            this.label12.TabIndex = 14;
            this.label12.Text = "Disconnected";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "Statut :";
            // 
            // cmb_cmdbluetooth
            // 
            this.cmb_cmdbluetooth.FormattingEnabled = true;
            this.cmb_cmdbluetooth.Location = new System.Drawing.Point(14, 384);
            this.cmb_cmdbluetooth.Name = "cmb_cmdbluetooth";
            this.cmb_cmdbluetooth.Size = new System.Drawing.Size(313, 40);
            this.cmb_cmdbluetooth.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "input command :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "received data :";
            // 
            // txt_bluetooth
            // 
            this.txt_bluetooth.Location = new System.Drawing.Point(14, 117);
            this.txt_bluetooth.Multiline = true;
            this.txt_bluetooth.Name = "txt_bluetooth";
            this.txt_bluetooth.Size = new System.Drawing.Size(313, 224);
            this.txt_bluetooth.TabIndex = 9;
            this.txt_bluetooth.TextChanged += new System.EventHandler(this.Txt_bluetooth_TextChanged);
            // 
            // btn_connectbluetooth
            // 
            this.btn_connectbluetooth.BackColor = System.Drawing.SystemColors.Control;
            this.btn_connectbluetooth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connectbluetooth.Location = new System.Drawing.Point(245, 34);
            this.btn_connectbluetooth.Name = "btn_connectbluetooth";
            this.btn_connectbluetooth.Size = new System.Drawing.Size(82, 40);
            this.btn_connectbluetooth.TabIndex = 7;
            this.btn_connectbluetooth.Text = "Connect";
            this.btn_connectbluetooth.UseVisualStyleBackColor = false;
            this.btn_connectbluetooth.Click += new System.EventHandler(this.Btn_connectbluetooth_Click);
            // 
            // cmb_bluetooth
            // 
            this.cmb_bluetooth.FormattingEnabled = true;
            this.cmb_bluetooth.Location = new System.Drawing.Point(71, 34);
            this.cmb_bluetooth.Name = "cmb_bluetooth";
            this.cmb_bluetooth.Size = new System.Drawing.Size(168, 40);
            this.cmb_bluetooth.TabIndex = 6;
            this.cmb_bluetooth.Click += new System.EventHandler(this.Cmb_bluetooth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "port :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_ip);
            this.groupBox3.Controls.Add(this.btn_sendwifi);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cmb_cmdwifi);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_wifi);
            this.groupBox3.Controls.Add(this.btn_connectwifi);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(826, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 573);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wifi";
            // 
            // btn_sendwifi
            // 
            this.btn_sendwifi.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sendwifi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendwifi.Location = new System.Drawing.Point(197, 428);
            this.btn_sendwifi.Name = "btn_sendwifi";
            this.btn_sendwifi.Size = new System.Drawing.Size(135, 40);
            this.btn_sendwifi.TabIndex = 15;
            this.btn_sendwifi.Text = "Send command";
            this.btn_sendwifi.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(115, 508);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 30);
            this.label14.TabIndex = 14;
            this.label14.Text = "Disconnected";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 513);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "Statut :";
            // 
            // cmb_cmdwifi
            // 
            this.cmb_cmdwifi.FormattingEnabled = true;
            this.cmb_cmdwifi.Location = new System.Drawing.Point(19, 382);
            this.cmb_cmdwifi.Name = "cmb_cmdwifi";
            this.cmb_cmdwifi.Size = new System.Drawing.Size(313, 40);
            this.cmb_cmdwifi.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "input command :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "received data :";
            // 
            // txt_wifi
            // 
            this.txt_wifi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wifi.Location = new System.Drawing.Point(19, 115);
            this.txt_wifi.Multiline = true;
            this.txt_wifi.Name = "txt_wifi";
            this.txt_wifi.Size = new System.Drawing.Size(313, 224);
            this.txt_wifi.TabIndex = 9;
            // 
            // btn_connectwifi
            // 
            this.btn_connectwifi.BackColor = System.Drawing.SystemColors.Control;
            this.btn_connectwifi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connectwifi.Location = new System.Drawing.Point(250, 32);
            this.btn_connectwifi.Name = "btn_connectwifi";
            this.btn_connectwifi.Size = new System.Drawing.Size(82, 40);
            this.btn_connectwifi.TabIndex = 7;
            this.btn_connectwifi.Text = "Connect";
            this.btn_connectwifi.UseVisualStyleBackColor = false;
            this.btn_connectwifi.Click += new System.EventHandler(this.Btn_connectwifi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ip :";
            // 
            // txt_ip
            // 
            this.txt_ip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ip.Location = new System.Drawing.Point(76, 33);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(168, 33);
            this.txt_ip.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 608);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Arduino Communication Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_cmdserial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_connectserial;
        private System.Windows.Forms.ComboBox cmb_serial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_cmdbluetooth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bluetooth;
        private System.Windows.Forms.Button btn_connectbluetooth;
        private System.Windows.Forms.ComboBox cmb_bluetooth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_cmdwifi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_wifi;
        private System.Windows.Forms.Button btn_connectwifi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sendserial;
        private System.Windows.Forms.Button btn_sendbluetooth;
        private System.Windows.Forms.Button btn_sendwifi;
        public System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.TextBox txt_ip;
    }
}

