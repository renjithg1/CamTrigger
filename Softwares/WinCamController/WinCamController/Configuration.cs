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
  "PortName":  "COM15",
  "PortSpeed": 57600,
 // "MyIntegerProperty": 1,
//  "MySubDocument": {
 //   "SubDocumentProperty": "SubDocumentValue"
  //},
  "DropSize": [
    10 ,
    15,
    20
  ]
}
*/





namespace WinCamController
{
    class Configuration
    {
        private class Mapped
        {
            public string Title { get; set; }
            public string PortName { get; set; }
            public Int32 PortSpeed { get; set; }
            public List<int> DropSize { get; set; }
        }

        private Mapped jsonMapped = new Mapped();

        public string Title   // Title
        {
            get { return jsonMapped.Title; }   // get method
        }

        public string PortName   // Portname
        {
            get { return jsonMapped.PortName; }   // get method
            set { jsonMapped.PortName = value; }   // set method
        }

        public Int32 Speed   // Title
        {
            get { return jsonMapped.PortSpeed; }   // get method
        }

        public Configuration(string configname)
        {
            var myJsonString = File.ReadAllText(configname);
            dynamic jToken = JToken.Parse(myJsonString);

            jsonMapped = JsonConvert.DeserializeObject<Mapped>(myJsonString);
        }        
    }
}
