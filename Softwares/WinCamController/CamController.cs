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
        private SerialPort serialPort = new SerialPort();
        private bool bSerialConnected = false;
        private Configuration configData = null;

        private FirmataProtocol protocol = new FirmataProtocol();

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
            btnPlay.Enabled = false;
            buttonTestDrop.Enabled = false;
            buttonTestFlash.Enabled = false;

            if (configData == null)
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

            int [] flashdelay = configData.FlashDelay;
            numericUpDownFlashDelay.Increment = flashdelay[0];
            numericUpDownFlashDelay.Value = flashdelay[1];
            numericUpDownFlashDelay.Minimum = flashdelay[2];
            numericUpDownFlashDelay.Maximum = flashdelay[3];

            // Drop 1 Size
            int[] drop1size = configData.Drop1Size;
            numericUpDownDrop1Size.Increment = drop1size[0];
            numericUpDownDrop1Size.Value = drop1size[1];
            numericUpDownDrop1Size.Minimum = drop1size[2];
            numericUpDownDrop1Size.Maximum = drop1size[3];

            // Drop 2 Delay
            int[] drop2delay = configData.Drop2Delay;
            numericUpDownDrop2Delay.Increment = drop2delay[0];
            numericUpDownDrop2Delay.Value = drop2delay[1];
            numericUpDownDrop2Delay.Minimum = drop2delay[2];
            numericUpDownDrop2Delay.Maximum = drop2delay[3];

            // Drop 2 Size
            int[] drop2size = configData.Drop2Size;
            numericUpDownDrop2Size.Increment = drop2size[0];
            numericUpDownDrop2Size.Value = drop2size[1];
            numericUpDownDrop2Size.Minimum = drop2size[2];
            numericUpDownDrop2Size.Maximum = drop2size[3];

            // Drop 3 Delay
            int[] drop3delay = configData.Drop3Delay;
            numericUpDownDrop3Delay.Increment = drop3delay[0];
            numericUpDownDrop3Delay.Value = drop3delay[1];
            numericUpDownDrop3Delay.Minimum = drop3delay[2];
            numericUpDownDrop3Delay.Maximum = drop3delay[3];

            // Drop 2 Size
            int[] drop3size = configData.Drop3Size;
            numericUpDownDrop3Size.Increment = drop3size[0];
            numericUpDownDrop3Size.Value = drop3size[1];
            numericUpDownDrop3Size.Minimum = drop3size[2];
            numericUpDownDrop3Size.Maximum = drop3size[3];


           // trackBarDrop2Delay.Value = 20;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCOnnect(object sender, EventArgs e)
        {
            if (!bSerialConnected)
            {
                // Allow the user to set the appropriate properties.
                serialPort.PortName = serialCombo.SelectedItem.ToString();
                serialPort.BaudRate = configData.Speed;
                /* serialPort.Parity = SetPortParity(serialPort.Parity);
                 serialPort.DataBits = SetPortDataBits(serialPort.DataBits);
                 serialPort.StopBits = SetPortStopBits(serialPort.StopBits);
                 serialPort.Handshake = SetPortHandshake(serialPort.Handshake);*/

                // Set the read/write timeouts
                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;
                try
                {
                    serialPort.Open();
                    bSerialConnected = true;
                    buttonConnect.Text = "Disconnect";
                    btnPlay.Enabled = true;
                    buttonTestFlash.Enabled = true;
                    buttonTestDrop.Enabled = true;
                }
                catch (Exception ex)
                {
                    bSerialConnected = false;
                    buttonConnect.Text = "Connect";
                    btnPlay.Enabled = false;
                    buttonTestFlash.Enabled = false;
                    buttonTestDrop.Enabled = false;
                }
            }
            else
            {
                serialPort.Close();
                bSerialConnected = false;
                buttonConnect.Text = "Connect";
                btnPlay.Enabled = false;
                buttonTestFlash.Enabled = false;
                buttonTestDrop.Enabled = false;
            }            
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkDrop2Property.Checked)
            {
                numericUpDownDrop2Delay.Enabled = true;
                numericUpDownDrop2Size.Enabled = true;
                trackBarDrop2Delay.Enabled = true;
                trackBarDrop2Size.Enabled = true;
            }
            else
            {
                numericUpDownDrop2Delay.Enabled = false;
                numericUpDownDrop2Size.Enabled = false;
                trackBarDrop2Delay.Enabled = false;
                trackBarDrop2Size.Enabled = false;
            }
        }

        private void checkDrop3Property_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDrop3Property.Checked)
            {
                numericUpDownDrop3Delay.Enabled = true;
                numericUpDownDrop3Size.Enabled = true;
                trackBarDrop3Delay.Enabled = true;
                trackBarDrop3Size.Enabled = true;
            }
            else
            {
                numericUpDownDrop3Delay.Enabled = false;
                numericUpDownDrop3Size.Enabled = false;
                trackBarDrop3Delay.Enabled = false;
                trackBarDrop3Size.Enabled = false;
            }
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            int flashdelay = Convert.ToInt32(Math.Round(numericUpDownFlashDelay.Value, 0));
            int drop1Size = Convert.ToInt32(Math.Round(numericUpDownDrop1Size.Value, 0));
            int drop2delay = Convert.ToInt32(Math.Round(numericUpDownDrop2Delay.Value, 0));
            int drop2Size = Convert.ToInt32(Math.Round(numericUpDownDrop2Size.Value, 0));

            if (checkDrop2Property.Checked)
            {
                int[] report = protocol.CreateReport(99, flashdelay, drop1Size, drop2delay, drop2Size);
                protocol.SendReport(ref serialPort, ref report);
            }
            else
            {
                int[] report = protocol.CreateReport(99, flashdelay, drop1Size);
                protocol.SendReport(ref serialPort, ref report);
            }
        }


    }
}
