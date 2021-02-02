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

#define TAP_PIN 4      // pin that controls the MOSFET
#define SHUTTER 25     // Shutter Pin
#define AUTO_FOCUS 26  // Autofocus Pin


WaterTap tap(TAP_PIN);
CameraController camera(SHUTTER, AUTO_FOCUS);


bool bTap = false;

void setup()
{
  Serial.begin(115200); // turn on serial communication

  tap.Init();           // 
  camera.Init();

  attachInterrupt(0, ShutterPress, FALLING);
  
  DbgMsg("IN SETUP");

  //pinMode(TAP_PIN,  OUTPUT);         // define control pin as output
  pinMode(SHUTTER,  OUTPUT);         // define control pin as output
  pinMode(AUTO_FOCUS,  OUTPUT);         // define control pin as output
}

void loop()
{

  DbgMsg("loop () ");
  if(bTap)
  {
    bTap = false;
   // tap.OpenTap(10);
  }

   //digitalWrite(TAP_PIN, HIGH);  // Turn ON the MOSFET switch
  // delay(100);               // Drop Duration / Drop size
   //digitalWrite(TAP_PIN, LOW);   // Turn OFF the MOSFET switch
   tap.OpenTap(100);

   camera.FocusPress();
   camera.ShutterPress(100);
   camera.ShutterRelease();
   camera.FocusRelease();

//   digitalWrite(SHUTTER, HIGH);  // Turn ON the MOSFET switch
//   digitalWrite(AUTO_FOCUS, HIGH);  // Turn ON the MOSFET switch
//   delay(100);               // Drop Duration / Drop size
//   digitalWrite(SHUTTER, LOW);   // Turn OFF the MOSFET switch
//   digitalWrite(AUTO_FOCUS, LOW);  // Turn ON the MOSFET switch



   delay(10000);               // Drop Duration / Drop size
}




void ShutterPress()
{
  bTap = true;
}

    

   
