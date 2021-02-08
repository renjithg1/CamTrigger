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

namespace WinCamController
{
    public partial class CamController : Form
    {
        private SerialPort _serialPort = new SerialPort();
        private bool bSerialConnected = false;
        private Configuration configData = null;

        private void SetPort(ref string portName)
        {
            //serialCombo.read
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            // Display each port name to the console.
            foreach (string port in ports)
            {
                serialCombo.Items.Add(port);
                if(port == portName)
                    serialCombo.SelectedItem = port;
            }            
        }

        private void InitializeWindow() 
        {
           if(configData == null)
            {
                throw new Exception("configuration data not Initialized");
            }

           // Set the window title
            this.Text = configData.Title;

            // set the window port fields
            var portName = configData.PortName;
            SetPort(ref portName);

            // Assign an image to the button.
            //btnPlay.Image = Image.FromFile("..\\..\\Resources\\play.png");


            // Flash Delay
            // Set the Minimum, Maximum, and initial Value.
            numericUpDownFlashDelay.Increment = 5;
            numericUpDownFlashDelay.Value = 25;
            numericUpDownFlashDelay.Maximum = 2500;
            numericUpDownFlashDelay.Minimum = 10;
        }


        public CamController()
        {
            InitializeComponent();

            configData = new Configuration("..\\..\\json1.json");

            InitializeWindow();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCOnnect(object sender, EventArgs e)
        {
            if (!bSerialConnected)
            {
                // Allow the user to set the appropriate properties.
                _serialPort.PortName = serialCombo.SelectedItem.ToString();
                _serialPort.BaudRate = configData.Speed;
                /* _serialPort.Parity = SetPortParity(_serialPort.Parity);
                 _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
                 _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
                 _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);*/

                // Set the read/write timeouts
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;
                try
                {
                    _serialPort.Open();
                    bSerialConnected = true;
                    buttonConnect.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    bSerialConnected = false;
                    buttonConnect.Text = "Connect";
                }
            }
            else
            {
                _serialPort.Close();
                bSerialConnected = false;
                buttonConnect.Text = "Connect";
            }            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int i = 80;
            byte b0 = (byte)i;
            byte b1 = (byte)(i >> 8);

            
        }
    }
}
