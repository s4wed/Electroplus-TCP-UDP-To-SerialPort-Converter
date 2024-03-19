using Gurux.Common;
using Gurux.Net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Electroplus_Media_Converter
{
    public partial class MainFrm : Form
    {

        GXNet net;
        List<string> ClientsList = new List<string>();
        public MainFrm()
        {
            InitializeComponent();

            comboBox_PortName.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())
            {
                comboBox_PortName.Items.Add(item);
            }

            comboBox_PortName.SelectedIndex = 0;
            comboBox_Type.SelectedIndex = 0;
            comboBox_Baudrate.SelectedIndex = 0;
            comboBox_setting.SelectedIndex = 0;
        }

        private void comboBox_PortName_MouseClick(object sender, MouseEventArgs e)
        {
            string main = comboBox_PortName.Text;
            comboBox_PortName.Items.Clear();
            foreach (var item in SerialPort.GetPortNames())
            {
                comboBox_PortName.Items.Add(item);
            }
            comboBox_PortName.SelectedItem = main;
        }

        private void button_start_Click(object sender, System.EventArgs e)
        {
            try
            {
                ClientsList.Clear();
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                serialPort1.PortName = comboBox_PortName.Text;

                serialPort1.BaudRate = Convert.ToInt32(comboBox_Baudrate.Text);
                if (comboBox_setting.Text == "8N1")
                {
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                }
                else if (comboBox_setting.Text == "7E1")
                {
                    serialPort1.DataBits = 7;
                    serialPort1.Parity = Parity.Even;
                    serialPort1.StopBits = StopBits.One;
                }

                serialPort1.Open();

                if (comboBox_Type.Text == "TCP Server")
                {
                    net = new GXNet(NetworkType.Tcp, decimal.ToInt32(numericUpDown_Port.Value));
                }
                else if (comboBox_Type.Text == "TCP Client")
                {
                    net = new GXNet(NetworkType.Tcp, textBox_IP.Text, decimal.ToInt32(numericUpDown_Port.Value));
                }
                else if (comboBox_Type.Text == "UDP Server")
                {
                    net = new GXNet(NetworkType.Udp, decimal.ToInt32(numericUpDown_Port.Value));
                }
                else if (comboBox_Type.Text == "UDP Client")
                {
                    net = new GXNet(NetworkType.Udp, textBox_IP.Text, decimal.ToInt32(numericUpDown_Port.Value));
                }

                net.OnClientConnected += new ClientConnectedEventHandler(Net1_OnClientConnected);
                net.OnClientDisconnected += new ClientDisconnectedEventHandler(Net1_OnClientDisconnected);
                net.OnReceived += new ReceivedEventHandler(Net1_OnReceived);
                net.Open();

                richTextBox_log.Invoke(new System.Action(() => richTextBox_log.AppendText("Serial And Network Is Ok! \r\r")));
            }
            catch (System.Exception ex)
            {
                richTextBox_log.Invoke(new System.Action(() => richTextBox_log.AppendText("Error : " + ex.Message + "\r\r")));
            }
        }

        private void Net1_OnReceived(object sender, ReceiveEventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new ReceivedEventHandler(Net1_OnReceived), new object[] { sender, e });
                }
                else
                {
                    if (ClientsList.Contains(e.SenderInfo) == false)
                        ClientsList.Add(e.SenderInfo);

                    serialPort1.Write((byte[])e.Data, 0, ((byte[])e.Data).Length);


                    richTextBox_log.Invoke(new System.Action(() => richTextBox_log.SelectionColor = Color.Green));
                    richTextBox_log.Invoke(new System.Action(() => richTextBox_log.AppendText("RS485 TX :  " + (BitConverter.ToString((byte[])e.Data).Replace("-", "")) + "\r\r")));


                }
            }
            catch (Exception ex)
            {
                richTextBox_log.Invoke(new System.Action(() => richTextBox_log.AppendText("Error : " + ex.Message + "\r\r")));
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(150);
                SerialPort sp = (SerialPort)sender;
                byte[] buffer = new byte[sp.BytesToRead];

                sp.Read(buffer, 0, buffer.Length);
                foreach (var item in ClientsList)
                {
                    net.Send(buffer, item);

                    richTextBox_log.Invoke(new System.Action(() => richTextBox_log.SelectionColor = Color.Red));
                    richTextBox_log.Invoke(new System.Action(() => richTextBox_log.AppendText("Net TX :  " + (BitConverter.ToString(buffer).Replace("-", "")) + "\r\r")));

                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// When new client has connected in server mode.
        /// </summary>
        private void Net1_OnClientConnected(object sender, ConnectionEventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new ClientConnectedEventHandler(Net1_OnClientConnected), new object[] { sender, e });
                }
                else
                {
                    ClientsList.Add(e.Info);
                }
            }
            catch (Exception ex)
            {
                richTextBox_log.Invoke(new System.Action(() => richTextBox_log.AppendText("Error : " + ex.Message + "\r\r")));
            }
        }

        private void Net1_OnClientDisconnected(object sender, ConnectionEventArgs e)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new ClientDisconnectedEventHandler(Net1_OnClientDisconnected), new object[] { sender, e });
                }
                else
                {
                    ClientsList.Remove(e.Info);
                }
            }
            catch (Exception ex)
            {
                richTextBox_log.Invoke(new System.Action(() => richTextBox_log.AppendText("Error : " + ex.Message + "\r\r")));
            }
        }

        private void richTextBox_log_TextChanged(object sender, EventArgs e)
        {
            richTextBox_log.Focus();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                if (net != null)
                {
                    net.Close();
                }

                if (serialPort1 != null && serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
