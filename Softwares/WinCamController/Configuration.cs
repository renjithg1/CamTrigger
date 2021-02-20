using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

/*
 {
  "Title": "CamTriggerApp",
  "PortName": "COM15",
  "PortSpeed": 57600,

  "FlashDelay": [5, 25, 10, 2500 ],
  "Drop1Size":  [ 5, 25, 10, 2500 ],
  "Drop2Delay": [5, 25, 10, 2500 ],
  "Drop2Size":  [ 5, 25, 10, 2500 ]
}
*/

namespace WinCamController
{
    class Configuration
    {
        private class ConfigurationSchema
        {
            public string Title { get; set; }
            public string PortName { get; set; }
            public int PortSpeed { get; set; }
            public int[] FlashDelay { get; set; }
            public int[] Drop1Size { get; set; }
            public int[] Drop2Delay { get; set; }
            public int[] Drop2Size { get; set; }
            public int[] Drop3Delay { get; set; }
            public int[] Drop3Size { get; set; }
        }

        private ConfigurationSchema jsonMapped = new ConfigurationSchema();

        public string Title   // Title
        {
            get { return jsonMapped.Title; }   // get method
        }

        public string PortName   // Portname
        {
            get { return jsonMapped.PortName; }   // get method
            set { jsonMapped.PortName = value; }   // set method
        }

        public int Speed   // Title
        {
            get { return jsonMapped.PortSpeed; }   // get method
        }

        public int[] FlashDelay   // Title
        {
            get { return jsonMapped.FlashDelay; }   // get method
        }

        public int[] Drop1Size   // Title
        {
            get { return jsonMapped.Drop1Size; }   // get method
        }

        public int[] Drop2Delay   // Title
        {
            get { return jsonMapped.Drop2Delay; }   // get method
        }

        public int[] Drop2Size   // Title
        {
            get { return jsonMapped.Drop2Size; }   // get method
        }


        public int[] Drop3Delay   // Title
        {
            get { return jsonMapped.Drop3Delay; }   // get method
        }

        public int[] Drop3Size   // Title
        {
            get { return jsonMapped.Drop3Size; }   // get method
        }

        public Configuration(string configname)
        {
            var myJsonString = File.ReadAllText(configname);
            //dynamic jToken = JToken.Parse(myJsonString);

            jsonMapped = JsonConvert.DeserializeObject<ConfigurationSchema>(myJsonString);
        }        
    }
}
