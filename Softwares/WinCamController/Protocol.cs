using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WinCamController
{
    class FirmataProtocol
    {
        const byte START_SYSEX = 0xF0;
        const byte END_SYSEX = 0xF7;
        const byte eVHIDReport = 0x0a;

        public FirmataProtocol()
        {


        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vArg"></param>
        /// <returns></returns>

        int GetDataLength(ref int [] vArg)
        {
            return vArg.Length;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        int CalculateChecksum(ref int[] data)
        {
            int checksum = 0;
            for (int i = 0; i < GetDataLength(ref data) - 1; ++i)
                checksum ^= data[i];

            return checksum;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public int[] CreateReport(int command, params int[] data)
        {
            int size = GetDataLength(ref data);
            int buffer_size = size + 3;
            int[] buffer = null;
            switch (size)
            {
                case 0:
                    break;
                case 1:
                    {
                        buffer = new int[buffer_size];
                        buffer[0] = buffer_size; //Size
                        buffer[1] = command;
                        buffer[2] = data[0];
                        buffer[3] = CalculateChecksum(ref buffer);
                        return buffer;
                    }
                case 2: // Single drop
                    {
                        buffer = new int[buffer_size];
                        buffer[0] = buffer_size; //Size
                        buffer[1] = command;
                        buffer[2] = data[0];
                        buffer[3] = data[1];
                        buffer[4] = CalculateChecksum(ref buffer);
                        return buffer;
                    }
                case 4: // Two drop
                    {
                        buffer = new int[buffer_size];
                        buffer[0] = buffer_size; //Size
                        buffer[1] = command;
                        buffer[2] = data[0];
                        buffer[3] = data[1];
                        buffer[4] = data[2];
                        buffer[5] = data[3];
                        buffer[6] = CalculateChecksum(ref buffer);
                        return buffer;
                    }
                case 6: // three drop
                    {
                        buffer = new int[buffer_size];
                        buffer[0] = buffer_size; //Size
                        buffer[1] = command;
                        buffer[2] = data[0];
                        buffer[3] = data[1];
                        buffer[4] = data[2];
                        buffer[5] = data[3];
                        buffer[6] = data[4];
                        buffer[7] = data[5];
                        buffer[8] = CalculateChecksum(ref buffer);
                        return buffer;
                    }
                default:
                    return null;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="port"></param>
        /// <param name="reports"></param>
        public void SendReport(ref SerialPort port, ref int[] reports)
        {
            byte[] protocol = new byte[100];

            protocol[0] = START_SYSEX;
            protocol[1] = eVHIDReport;

            //port.Write(abc, 0, 1);
            int index = 2;
            foreach (int report in reports)
            {
                //  protocol
                byte[] data = new byte[2];

                data[0] = (byte)(report & 0xFF);
                data[1] = (byte)((report >> 8) & 0xFF);

                protocol[index++] = (byte)(data[1] & 0x7F);
                protocol[index++] = (byte)(data[1] >> 7);
                protocol[index++] = (byte)(data[0] & 0x7F);
                protocol[index++] = (byte)(data[0] >> 7);                
            }
            protocol[index++] = END_SYSEX;
            port.Write(protocol, 0, index);

        }
    }
}
