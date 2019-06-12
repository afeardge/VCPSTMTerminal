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

namespace VCPSTMTerminal
{
    public partial class Form1 : Form
    {
        List<SerialPort> _serialPort = new List<SerialPort>();
        string[] Ports = SerialPort.GetPortNames();
        int CurrentPort = 0;
        byte[] ClearHexValue = new byte[3] { 0x00, 0x00, 0x00 };
        //DELEGATE
        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.TxRx.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.TxRx.Text += "IN(" + _serialPort[CurrentPort].PortName + ")<< " + text + Environment.NewLine;
            }
        }
        //DELEGATE

        public Form1()
        {
            InitializeComponent();
            
            
            for (int i = 0; i < Ports.Length; i++)
            {
                _serialPort.Add(new SerialPort());
                _serialPort[i].PortName = Ports[i];
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            SetText(indata);


        }



        private void Tm1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GetPorts_Click(object sender, EventArgs e)
        {
            Ports = SerialPort.GetPortNames();
            int CurrentPort = 0;
            PortList.Items.Clear();
            
            for (int i = 0; i < _serialPort.Count; i++)
            {
                PortList.Items.Add(_serialPort[i].PortName);
            }
            PortList.SelectedIndex = 0;
            CurrentPort = PortList.SelectedIndex;
        }

        private void PortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPortStatus(_serialPort[PortList.SelectedIndex].IsOpen);
            CurrentPort = PortList.SelectedIndex;
        }

        private void OpenPort_Click(object sender, EventArgs e)
        {
            
            if (!_serialPort[PortList.SelectedIndex].IsOpen)
            {
                _serialPort[PortList.SelectedIndex].Open();
            }
            GetPortStatus(_serialPort[PortList.SelectedIndex].IsOpen);
            _serialPort[CurrentPort].DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void ClosePort_Click(object sender, EventArgs e)
        {
            
            if (_serialPort[PortList.SelectedIndex].IsOpen)
            {
                _serialPort[PortList.SelectedIndex].Close();
            }
            GetPortStatus(_serialPort[PortList.SelectedIndex].IsOpen);
        }
        
        void GetPortStatus(bool status)
        {
            if (status)
            {
                PortConnectedStatus.Text = "Open";
                PortConnectedStatus.ForeColor = Color.Green;
            }
            else
            {
                PortConnectedStatus.Text = "Closed";
                PortConnectedStatus.ForeColor = Color.Red;
            }
        }

        private void CommandPalete_EnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (_serialPort[CurrentPort].IsOpen)
                {
                    TxRx.Text += "OUT(" +_serialPort[CurrentPort].PortName + ")>> " + CommandPalete.Text + Environment.NewLine;
                    _serialPort[CurrentPort].Write(CommandPalete.Text);
                    CommandPalete.Clear();
                }
            }
        }

        private void ClearTxRx_Click(object sender, EventArgs e)
        {
            TxRx.Clear();
        }

        private void SPI_Click(object sender, EventArgs e)
        {

        }

        private void SPI_Clear_Click(object sender, EventArgs e)
        {
            SPI_Send.Clear();
        }

        private void SPI_Send_EnterPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                if (_serialPort[CurrentPort].IsOpen)
                {
                    TxRx.Text += "OUT(" + _serialPort[CurrentPort].PortName + ")>> " + SPI_Send.Text + Environment.NewLine;
                    _serialPort[CurrentPort].Write(ConvertToHex(SPI_Send),0, ConvertToHex(SPI_Send).Length);
                }
                //DBG.Text = SPI_Send.Text;
            }
        }
        private byte[] ConvertToHex(RichTextBox richTextBox)
        {
            string InitialString = richTextBox.Text.Replace(" ", "");
            byte[] ByteString1 = new byte[InitialString.Length/2];
            for (int i = 0; i< ByteString1.Length; i++)
            {
                ByteString1[i] = Convert.ToByte(InitialString.Substring(i*2, 2), 16);
            }
            return ByteString1;
        }
        private byte[] ConvertToHex(TextBox TextBox)
        {
            string InitialString = TextBox.Text.Replace(" ", "");
            byte[] ByteString1 = new byte[InitialString.Length / 2];
            for (int i = 0; i < ByteString1.Length; i++)
            {
                ByteString1[i] = Convert.ToByte(InitialString.Substring(i * 2, 2), 16);
            }
            return ByteString1;
        }

        private void Updatetext(TextBox textBox, byte[] Byte)
        {
            string Initialstring = textBox.Text;
            string Replace = Convert.ToString(Byte[0]);
            Initialstring = Initialstring.Remove(0, 2);
            Initialstring = Initialstring.Insert(0, Replace);
            textBox.Text = Initialstring;
        }


        private void SPI_Write_CheckedChanged(object sender, EventArgs e)
        {
            if (SPI_Write.Checked)
                SPI_Read.Checked = false;
        }

        private void SPI_Read_CheckedChanged(object sender, EventArgs e)
        {
            if (SPI_Read.Checked)
                SPI_Write.Checked = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ClearHexValue[0] = Convert.ToByte(RegNo.Value);
            Updatetext(ClearHex, ClearHexValue);
        }
    }
}
