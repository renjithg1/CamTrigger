/*
 * 
 * size - 1/24/5:00pm 4176 12 %  GB 447  21%  
 * 1/31               261967  19% 
 */



#include <Wire.h> 
//#include <LiquidCrystal_I2C.h>

#include "WaterTap.h"
#include "CameraController.h"
#include "utilities.h"

#include "FirmataLite.h"   

#define TAP_PIN 4      // pin that controls the MOSFET
#define SHUTTER 25     // Shutter Pin
#define AUTO_FOCUS 26  // Autofocus Pin


WaterTap tap(TAP_PIN);
CameraController camera(SHUTTER, AUTO_FOCUS);
bool bTap = false;

volatile int interruptCounter;
int totalInterruptCounter;
 
hw_timer_t * timer = NULL;
portMUX_TYPE timerMux = portMUX_INITIALIZER_UNLOCKED;


#define SerialDataBits 57600
HardwareSerial SerialController( 2 );
 
void IRAM_ATTR onTimer() {
  portENTER_CRITICAL_ISR(&timerMux);
  interruptCounter++;
  portEXIT_CRITICAL_ISR(&timerMux);

}

#define eVHIDReport 0x0a
#define eResetESP 0x0f
#define eIsESPReady 0x0e

void setup()
{
  //Serial.begin(115200);                 // turn on serial communication
  tap.Init();                           // 
  camera.Init();

  //attachInterrupt(0, ShutterPress, FALLING);
  
  DbgMsg("IN SETUP");

  //pinMode(TAP_PIN,  OUTPUT);          // define control pin as output
  //pinMode(SHUTTER,  OUTPUT);            // define control pin as output
  //pinMode(AUTO_FOCUS,  OUTPUT);         // define control pin as output

    // Init Firmata 
  FirmataLite.attach(START_SYSEX, sysexCallback);
  FirmataLite.begin(57600);


  timer = timerBegin(0, 80, true);
  timerAttachInterrupt(timer, &onTimer, true);
//  timerAlarmWrite(timer, 8000000, true);
  //timerAlarmEnable(timer);  

  SerialController.begin( SerialDataBits );
}

static uint16_t ExtractUInt16(uint8_t* buf, uint8_t i)
{
    uint16_t res0 = buf[4 * i + 0];
    res0 |= buf[4 * i + 1] << 7;

    uint16_t res1 = buf[4 * i + 2];
    res1 |= buf[4 * i + 3] << 7;

    return res0 << 8 | res1;
}

static void ProcessVHIDReport(uint8_t argc, uint8_t *argv)
{
  enum { LEN, CMD, ARG0, ARG1, ARG2, ARG3, CHKSUM, CAPACITY };
  uint16_t vHIDReport[CAPACITY];

 // if (argc > 4 * CAPACITY)
  //  FSend("argc > 4 * CAPACITY");

  /*for (int i = 0; i < CAPACITY; i++)
    vHIDReport[i] = 0;
    */
  memset(vHIDReport, 0, CAPACITY);
  
  uint16_t len = ExtractUInt16(argv, LEN);
  for (int i = 0; i < len; i++)
  {
    vHIDReport[i] = ExtractUInt16(argv, i);
    SerialController.print(vHIDReport[i]);
    SerialController.println("--");
  }

  //if (!BT_KBM_Emulator::ProcessHIDReport(vHIDReport))
  {
    //SetErrorLED();
  }
  switch(vHIDReport[0])
  {
    case 5:
    return TakeDropPhotos(vHIDReport[2], vHIDReport[3]);
    case 7:
    return TakeDropPhotos(vHIDReport[2], vHIDReport[3], vHIDReport[4], vHIDReport[5]);
  }
  
}

void TakeDropPhotos(int flashDelay, int drop1Size)
{
  SerialController.println("-TakeDropPhotos Single Drop-");
  tap.OpenTap(drop1Size);
  delay(flashDelay);
  camera.FocusPress();
  camera.ShutterPress(100);
  camera.ShutterRelease();
  camera.FocusRelease();
}

void TakeDropPhotos(int flashDelay, int drop1Size, int drop2Delay, int drop2Size)
{
  SerialController.println("-TakeDropPhotos two Drop-");
  tap.OpenTap(drop1Size);
  delay(drop2Delay);
  tap.OpenTap(drop2Size);
  delay(flashDelay);
  camera.FocusPress();
  camera.ShutterPress(100);
  camera.ShutterRelease();
  camera.FocusRelease();
}

// On sysex message from host
void sysexCallback(byte command, byte argc, byte*argv)
{
    SerialController.println("sysexCallback()");
    //tap.OpenTap(100);
    SerialController.print("Command:");
    SerialController.print(command);
    SerialController.println("");
    SerialController.print("argc:");
    SerialController.print(argc);
    SerialController.println("");

    switch (command) 
  {
      case eVHIDReport:
          // The command is a HID report.
          ProcessVHIDReport(argc, argv);
          break;

      case eResetESP:
          ESP.restart();
          break;

      case eIsESPReady:
          // A IsESPReady query message is send by caller to overcome the boot (1,7) issue.
          // If the packet is received correctly, we will write "espReady" immediately to serial. 
          // The caller can listen (read) the serial and take actions based on the return value. 
          // This is a tricky workaround. 
          Serial.println("espReady");
          break;
  }
}

inline void FSend(String msg)
{
  SerialController.println(msg.c_str());
  //Firmata.sendString(msg.c_str());
}

static void StringCallback(char *str)
{
  FSend(str);
}


static int counter=0;
int serIn = 0; // for incoming serial data

void loop()
{
  
//   tap.OpenTap(100);
//   camera.FocusPress();
//   camera.ShutterPress(100);
//   camera.ShutterRelease();
//   camera.FocusRelease();

//  while (FirmataLite.available()) {
//    //  DbgMsg("InSide FirmataLite While () ");
//    SerialController.print(counter++);
//    SerialController.println(" : InSide :");
//    FirmataLite.processInput();
//  }

  /* processing incoming serial messags */
  while (FirmataLite.available())
  {
    FirmataLite.processInput();    
  }

  if (interruptCounter > 0) {
 
    portENTER_CRITICAL(&timerMux);
    interruptCounter--;
    portEXIT_CRITICAL(&timerMux);
 
    totalInterruptCounter++;
 
    Serial.print("An interrupt as occurred. Total number: ");
    Serial.println(totalInterruptCounter);
   }
}




void ShutterPress()
{
  bTap = true;
}

    

   
