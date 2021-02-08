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


// On sysex message from host
void sysexCallback(byte command, byte argc, byte*argv)
{
    SerialController.println("sysexCallback()");
    tap.OpenTap(100);

//    switch (command) 
//  {
//      case eVHIDReport:
//          // The command is a HID report.
//          ProcessVHIDReport(argc, argv);
//          break;
//
//      case eResetESP:
//          ESP.restart();
//          break;
//
//      case eIsESPReady:
//          // A IsESPReady query message is send by caller to overcome the boot (1,7) issue.
//          // If the packet is received correctly, we will write "espReady" immediately to serial. 
//          // The caller can listen (read) the serial and take actions based on the return value. 
//          // This is a tricky workaround. 
//          Serial.println("espReady");
//          break;
//  }
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

    

   
