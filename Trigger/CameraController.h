/*
 *  
 */

 class CameraController
 {

  public:
  protected:
  
  private:

    unsigned short m_sShutterPin;
    unsigned short m_sFocusPin;

  public:
    CameraController() = delete;
    CameraController(short shutterPin, short focusPin): m_sShutterPin(shutterPin), m_sFocusPin(focusPin)
    {
       Serial.println("IN CameraController");
    }

    void Init()
    {
      Serial.println("IN CameraController Init");
      pinMode(m_sShutterPin,  OUTPUT);         // define
      pinMode(m_sFocusPin,  OUTPUT);         // define c
    }

    void FocusPress(short duration=1)
    {
      digitalWrite(m_sFocusPin, HIGH);  // Turn ON
      delay(duration);               // Drop D
    }

    void FocusRelease()
    {
      digitalWrite(m_sFocusPin, LOW);  // Turn O
    }

    void ShutterPress(short duration=1)
    {
      digitalWrite(m_sShutterPin, HIGH);  // Turn ON
      delay(duration);               // Drop D
    }

    void ShutterRelease()
    {
      digitalWrite(m_sShutterPin, LOW);  // Turn O
    }
 
    
  protected:
  private:
    
 };
 
