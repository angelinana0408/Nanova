// the setup function runs once when you press reset or power the board
void setup() {
  initial_set_Ports_Low();

  // initalize the  data ready and chip select pins:
  pinMode(PIN_ADS1262_DRDY, INPUT);                  //data ready input line
  pinMode(PIN_ADS1262_CS, OUTPUT);                   //chip enable output line
  pinMode(PIN_ADS1262_START, OUTPUT);               // start
  pinMode(PIN_ADS1262_PWDN, OUTPUT);                // Power down output 

  Serial.begin(250000);//250 Kbps = 31 KB/s, keep it fastest or it will not be able to keep up the rate of adc/dac 
 
  PC_ADS1262.ads1262_Init(SPS_1200,VREF_INTERNAL,PIN_ADS1262_START,PIN_ADS1262_CS,PIN_ADS1262_DRDY,PIN_ADS1262_PWDN); 

  dac.begin(0x62);
}

void loop() {
  // print the string when a newline arrives:
  if (stringComplete) {
    if (inputString != "")
    {
      ExtractProfileString(inputString);
      Serial.print("Ready");
      // clear the string:
      inputString = "";
    }
  }
  //Read command from UWP
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    if (stringComplete)
    {
      if (inChar == 's')
      {
        Time_start = micros();
        stringComplete = true;
        StartTestFlag = true;
        initialVariable();
        //set pressure
        dac.setVoltage(SetPressurevalue, false); // DAC output: 4095 for 5V, 0 for 0V
        inChar = '-';
      }
      else if (inChar == 'e')
      { 
        stringComplete = true;
        StartTestFlag = false;
        inputString = "";
        inChar = '-';
      }
      else if (inChar == 't')
      { 
        Time_stop = micros();
        Time_now = micros();
        inputString = "";
        inChar = '-';
      }
      else if (inChar == '!')
      {
        stringComplete = false;
      }
      else;
    }
    else
    {
      // add it to the inputString:
      inputString += inChar;
      // if the incoming character is a newline, set a flag
      // so the main loop can do something about it:
      if (inChar == '\n') {
        stringComplete = true;
      }
    }
  }
  //timer start
  if (StartTestFlag)
  {
    timerMenu_Tick();
  }
  else
  {
    Time_start = 0;
    initial_set_Ports_Low();
  }
}
