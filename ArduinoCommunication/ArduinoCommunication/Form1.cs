using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;

namespace ArduinoCommunication
{
    public partial class Form1 : Form
    {
        static SerialPort port,bluetooth_port;
        public string textreceived, textreceived_bluetooth;
        private cServerClass server;
        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();
        }

        private void Cmb_serial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_serial_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmb_serial.Items.Clear();
            cmb_serial.Items.AddRange(ports);
        }

        private void Btn_connectserial_Click(object sender, EventArgs e)
        {
            txt_serial.Clear();
            if (btn_connectserial.Text == "Connect")
            {
                if (cmb_serial.Text.Length > 1)
                {
                    port = new SerialPort(cmb_serial.Text, 9600, Parity.None, 8, StopBits.One);
                    port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    port.Open();

                    btn_connectserial.Text = "Disconnect";
                    label11.Text = "Connected";
                    label11.ForeColor = Color.Green;
                }

            }
            else
            {
                port.Close();
                btn_connectserial.Text = "Connect";
                label11.Text = "Disconnected";
                label11.ForeColor = Color.Red;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            textreceived= port.ReadLine();
            this.BeginInvoke(new EventHandler(processdata));
        }

        private void processdata(object sender, EventArgs e)
        {
            txt_serial.Text += "\n"+textreceived;
        }

        private void Btn_sendserial_Click(object sender, EventArgs e)
        {
            port.Write(cmb_cmdserial.Text);
        }

        private void Txt_serial_TextChanged(object sender, EventArgs e)
        {
            txt_serial.SelectionStart = txt_serial.TextLength;
            txt_serial.ScrollToCaret();
        }

        private void Cmb_bluetooth_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cmb_bluetooth.Items.Clear();
            cmb_bluetooth.Items.AddRange(ports);
        }

        private void Btn_connectbluetooth_Click(object sender, EventArgs e)
        {
            txt_bluetooth.Clear();
            if (btn_connectbluetooth.Text == "Connect")
            {
                if (cmb_bluetooth.Text.Length > 1)
                {
                    bluetooth_port = new SerialPort(cmb_bluetooth.Text, 9600, Parity.None, 8, StopBits.One);
                    bluetooth_port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler_bluetooth);
                    bluetooth_port.Open();

                    btn_connectbluetooth.Text = "Disconnect";
                    label12.Text = "Connected";
                    label12.ForeColor = Color.Green;
                }

            }
            else
            {
                bluetooth_port.Close();
                btn_connectbluetooth.Text = "Connect";
                label12.Text = "Disconnected";
                label12.ForeColor = Color.Red;
            }
        }

        private void Txt_bluetooth_TextChanged(object sender, EventArgs e)
        {
            txt_bluetooth.SelectionStart = txt_serial.TextLength;
            txt_bluetooth.ScrollToCaret();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private delegate void UpdateTxtbox(TextBox txtbox1, string txt);
        
        private void UpdateTxt(TextBox txtbox1, string txt)
        {
            if (InvokeRequired)
            {
                txtbox1.Invoke(new UpdateTxtbox(UpdateTxt), new object[] { txt_wifi, txt });

            }else if(txt != null)
            {
                txtbox1.AppendText(txt + "\n");
            }
        }
        private void RecInfo(cServerClass sender, string data)
        {
            UpdateTxt(txt_wifi, data);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_connectwifi.Text == "Disconnect")
            server.IsListening = false;
        }

        private void Btn_connectwifi_Click(object sender, EventArgs e)
        {
            if(btn_connectwifi.Text == "Connect")
            {
                string StringHost;
                string StrIP;

                try
                {
                    StringHost = System.Net.Dns.GetHostName();
                    StrIP = Dns.GetHostByName(StringHost).AddressList[2].ToString();

                }
                catch (Exception ex)
                {

                }

                server = new cServerClass(txt_ip.Text);
                try
                {
                    txt_wifi.AppendText("----- Wifi server is running-----\n");
                }
                catch (Exception ex)
                {

                }

                server.Message += RecInfo;
                btn_connectwifi.Text = "Disconnect";
                label14.Text = "Connected";
                label14.ForeColor = Color.Green;

            }
            else if(btn_connectwifi.Text == "Disconnect")
            {

                txt_wifi.Clear();
                server.IsListening = false;
                btn_connectwifi.Text = "Connect";
                label14.Text = "Disconnected";
                label14.ForeColor = Color.Red;
            }
            
        }

        private void Btn_sendbluetooth_Click(object sender, EventArgs e)
        {

        }

        private void DataReceivedHandler_bluetooth(object sender, SerialDataReceivedEventArgs e)
        {
            
            textreceived_bluetooth = bluetooth_port.ReadLine();
            this.BeginInvoke(new EventHandler(processdata_blutooth));
        }

        private void processdata_blutooth(object sender, EventArgs e)
        {
            txt_bluetooth.Text += textreceived_bluetooth;
        }
    }
}
