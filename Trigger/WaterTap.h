/*
 *  
 */


class WaterTap
{
  public:
  protected:
  
  private:
    unsigned short m_sControlPin;

  public:
    WaterTap() = delete;
    WaterTap(short pin): m_sControlPin(pin)
    {
      Serial.println("IN WaterTap");
    }

    void Init()
    {
      Serial.println("IN WaterTap Init");
      pinMode(m_sControlPin,  OUTPUT);         // define control pin as output
    }
 
    void OpenTap(unsigned long dropSize)
    {
      digitalWrite(m_sControlPin, HIGH);  // Turn ON the MOSFET switch
      delay(dropSize);               // Drop Duration / Drop size
      digitalWrite(m_sControlPin, LOW);   // Turn OFF the MOSFET switch
    }

    void OpenTap(unsigned long delayToOpen, unsigned long dropSize)
    {
      delay(delayToOpen);               // Drop Duration / Drop size
      digitalWrite(m_sControlPin, HIGH);  // Turn ON the MOSFET switch
      delay(dropSize);               // Drop Duration / Drop size
      digitalWrite(m_sControlPin, LOW);   // Turn OFF the MOSFET switch
    }
  protected:
  private:
    
      
};
