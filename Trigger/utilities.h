

char*       dbgprint( const char* format, ... ) ;

char* dbgprint ( const char* format, ... )
{
//  static char sbuf[DEBUG_BUFFER_SIZE] ;                // For debug lines
//  va_list varArgs ;                                    // For variable number of params
//
//  va_start ( varArgs, format ) ;                       // Prepare parameters
//  vsnprintf ( sbuf, sizeof(sbuf), format, varArgs ) ;  // Format the message
//  va_end ( varArgs ) ;                                 // End of using parameters
//  if ( DEBUG )                                         // DEBUG on?
//  {
//    Serial.print ( "D: " ) ;                           // Yes, print prefix
//    Serial.println ( sbuf ) ;                          // and the info
//  }
//  return sbuf ;                                        // Return stored string
}


template <typename TYPE>
void DbgMsg(TYPE & msg)
{
  Serial.println(msg);
}

template <typename TYPE>
void DbgMsg(const TYPE & msg)
{
  Serial.println(msg);
}


enum LogLevel
{
  None = 0,                 //        0
  Info = 1,                 //        1
  Debug = 2,                //       10
  Warning = 4,              //      100
  Error = 8,                //     1000
  FunctionalMessage = 16,   //    10000
  FunctionalError = 32,     //   100000
  All = 63                  //   111111
};
