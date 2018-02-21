
void initial_set_Ports_Low() {
  pinMode(PrimaryValves, OUTPUT); //initial_set_Ports_Low
  pinMode(PreconControl, OUTPUT);
  pinMode(FanPort, OUTPUT);
  pinMode(ColumnPort, OUTPUT);
  pinMode(P0_5, OUTPUT);
  pinMode(Precon2HL, OUTPUT);
  pinMode(Precon2Control, OUTPUT);
  pinMode(SecondaryValve, OUTPUT);
  pinMode(P1_1, OUTPUT);
  pinMode(PumpPort, OUTPUT);
  pinMode(PreconHL, OUTPUT);
  digitalWrite(PrimaryValves, LOW); //all digital ports set to low
  digitalWrite(PreconControl, LOW);
  digitalWrite(FanPort, LOW);
  digitalWrite(ColumnPort, LOW);
  digitalWrite(P0_5, LOW);
  digitalWrite(Precon2HL, LOW);
  digitalWrite(Precon2Control, LOW);
  digitalWrite(SecondaryValve, LOW);
  digitalWrite(P1_1, LOW);
  digitalWrite(PumpPort, LOW);
  digitalWrite(PreconHL, LOW);
}
void initialVariable() {
  PreviousTotalTime = 0;
  Time_stop = 0;
  TotalStopTime = 0;
  inputString = "";
  error = 0;
  integral = 0;
  derivative = 0;
  preError = 0;
  PIDFeedbackOutput = 0;
  PIDFeedbackPersentage = 0;
  SetTemp = 25;
  ActualTemp = 25;
}
void timerMenu_Tick() {
  //primary
  Time_now = micros();
  TotalTime = (Time_now - Time_start) / 1000.0;
  if (TotalTime - PreviousTotalTime > 95)
  {
    PreviousTotalTime = TotalTime;
    ActualTempVoltage = PC_ADS1262.ads1262_Read_Channel(0x1A) * 2;  //mV
    ActualTemp = (ActualTempVoltage / 1000.0 - 1.25) / 0.005;
    PIDSignal1 = PC_ADS1262.ads1262_Read_Channel(0x2A);
    PIDSignal2 = PC_ADS1262.ads1262_Read_Channel(0x3A);
    ActualPressure = PC_ADS1262.ads1262_Read_Channel(0x4A);

    //Calculate PID feedback persentage
    SetTemp = tempFunction();
    PIDFeedbackOutput = PIDControl(SetTemp, ActualTemp);
    if (PIDFeedbackOutput < 0)
    {
      PIDFeedbackPersentage = 0;
      integral = 0;
    }
    else if (PIDFeedbackOutput < 100)
    {
      PIDFeedbackPersentage = PIDFeedbackOutput;
    }
    else
    {
      PIDFeedbackPersentage = 100;
    }
    analogWrite(ColumnPort, PIDFeedbackPersentage);

    //Control process
    if (TotalTime < (pumpingTvalue * 1000))
    {
      digitalWrite(PumpPort, HIGH);
      digitalWrite(PrimaryValves, HIGH);
      Serial.print(-1);
    }
    else if (TotalTime < ((pumpingTvalue + waitingTvalue) * 1000))
    {
      digitalWrite(PumpPort, LOW);
      digitalWrite(PrimaryValves, LOW);
      Serial.print(-2);
    }
    else if (TotalTime < ((pumpingTvalue + waitingTvalue + preconHighTvalue) * 1000))
    {
      digitalWrite(PumpPort, LOW);
      digitalWrite(PrimaryValves, LOW);
      digitalWrite(PreconHL, HIGH);
      digitalWrite(PreconControl, HIGH);
      Serial.print(TotalTime / 1000.0 - (pumpingTvalue + waitingTvalue), 8);
    }
    else if (TotalTime < ((pumpingTvalue + waitingTvalue + preconHighTvalue + preconLowTvalue) * 1000))
    {
      digitalWrite(PumpPort, LOW);
      digitalWrite(PrimaryValves, LOW);
      digitalWrite(PreconHL, LOW);
      analogWrite(PreconControl, 50);
      Serial.print(TotalTime / 1000.0 - (pumpingTvalue + waitingTvalue), 8);
    }
    else if (TotalTime < ((pumpingTvalue + waitingTvalue + analysisTotalT) * 1000))
    {
      digitalWrite(PreconControl, LOW);
      Serial.print(TotalTime / 1000.0 - (pumpingTvalue + waitingTvalue), 8);
    }
    else
    {
      if (Time_stop == 0)
      {
        Time_stop = micros();
        Time_now = micros();
      }
      Serial.print(-3);
    }
    Serial.print(",");
    Serial.print(PIDSignal1, 8);
    Serial.print(",");
    Serial.print(PIDSignal2, 8);
    Serial.print(",");
    Serial.print(ActualTemp, 8); 
    Serial.print(",");
    Serial.print(SetTemp, 8);
    Serial.print(",");
    Serial.print(ActualPressure, 8);
    Serial.print(",");
    Serial.println(PIDFeedbackPersentage, 8);

    //cleaning
    if (Time_stop != 0)
    {
      TotalStopTime = (Time_now - Time_stop) / 1000;
      //no heating cleaning
      if ((Time_stop - Time_start) / 1000000.0 - (pumpingTvalue + waitingTvalue) < 120)
      {
        if (TotalStopTime < ((cleaningTvalue) * 1000))
        {
          digitalWrite(PreconHL, LOW);
          digitalWrite(PreconControl, LOW);
        }
        else if (TotalStopTime < ((cleaningTvalue + CoolingTvalue) * 1000)) //cooling use fan
        {
          digitalWrite(FanPort, HIGH);
        }
        else
        {
          initial_set_Ports_Low();
          StartTestFlag = false;
        }
      }
      //cleaning with precon high and low heating
      else
      {
        if (TotalStopTime < (cleaningHvalue * 1000))
        {
          digitalWrite(PreconHL, HIGH);
          digitalWrite(PreconControl, HIGH);
        }
        else if (TotalStopTime < ((cleaningHvalue + cleaningPvalue) * 1000))
        {
          digitalWrite(PreconHL, LOW);
          analogWrite(PreconControl, 50);
        }
        else if (TotalStopTime < ((cleaningTvalue) * 1000))
        {
          digitalWrite(PreconControl, LOW);
        }
        else if (TotalStopTime < ((cleaningTvalue + CoolingTvalue) * 1000)) //cooling use fan
        {
          digitalWrite(FanPort, HIGH);
        }
        else
        {
          initial_set_Ports_Low();
          StartTestFlag = false;
        }
      }
    }
    //2D
    if (heartcuttingNumber > 0)
    {
      if (heartcuttingflag == 0)
        heartcuttingflag = 1;
      if (TotalTime < (pumpingTvalue * 1000))
      {
        if (TotalTime < (preconHighTvalue * 1000))     //2D clean
        {
          digitalWrite(Precon2HL, HIGH);
          digitalWrite(Precon2Control, HIGH);
        }
        else if (TotalTime < ((preconHighTvalue + preconLowTvalue) * 1000))
        {
          digitalWrite(Precon2HL, LOW);
          analogWrite(Precon2Control, 50);
        }
        else
        {
          digitalWrite(Precon2Control, LOW);
        }
      }
      else if (heartcuttingflag <= heartcuttingNumber)
      {
        if (TotalTime < ((pumpingTvalue + waitingTvalue + heartcuttingStartList[heartcuttingflag]) * 1000))
        {
          digitalWrite(Precon2HL, LOW);
          digitalWrite(Precon2Control, LOW);
          digitalWrite(SecondaryValve, LOW);
        }
        else if (TotalTime < ((pumpingTvalue + waitingTvalue + heartcuttingEndList[heartcuttingflag]) * 1000))
        {
          digitalWrite(SecondaryValve, HIGH);
        }
        else if (TotalTime < ((pumpingTvalue + waitingTvalue + heartcuttingEndList[heartcuttingflag] + preconHighTvalue) * 1000))
        {
          digitalWrite(SecondaryValve, LOW);
          digitalWrite(Precon2HL, HIGH);
          digitalWrite(Precon2Control, HIGH);
        }
        else if (TotalTime < ((pumpingTvalue + waitingTvalue + heartcuttingEndList[heartcuttingflag] + preconHighTvalue + preconLowTvalue) * 1000))
        {
          digitalWrite(SecondaryValve, LOW);
          digitalWrite(Precon2HL, LOW);
          analogWrite(Precon2Control, 50);
        }
        else
        {
          digitalWrite(Precon2Control, LOW);
          heartcuttingflag++;
        }
      }
    }
  }
}
void ExtractProfileString(String ProfileString) {
  int CommaIndex = 0;
  int StartIndex = 0;
  for (int paraindex = 0; paraindex < 20; paraindex++)
  {
    CommaIndex =  ProfileString.indexOf(',', StartIndex);
    InputArray[paraindex] = ProfileString.substring(StartIndex, CommaIndex).toFloat();
    //Serial.print(InputArray[paraindex]); Serial.print(" ");
    //Serial.print(StartIndex); Serial.print(" ");
    //Serial.print(CommaIndex); Serial.println();
    StartIndex = CommaIndex + 1;
  }
  pumpingTvalue = InputArray[0];      //unit:s
  SetPressurevalue = InputArray[1];
  waitingTvalue = InputArray[2];      //unit:s
  lowestTempvalue = InputArray[3];
  lowestTvalue = InputArray[4];      //unit:s
  Temp1value = InputArray[5];
  HoldT1value = InputArray[6];       //unit:s
  RampSpeed1value = InputArray[7];
  Temp2value = InputArray[8];
  HoldT2value = InputArray[9];       //unit:s
  RampSpeed2value = InputArray[10];
  heartcuttingNumber = InputArray[11];
  heartcuttingStartList[1] = InputArray[12]; //[0] is empty
  heartcuttingStartList[2] = InputArray[13];
  heartcuttingStartList[3] = InputArray[14];
  heartcuttingStartList[4] = InputArray[15];
  heartcuttingEndList[1] = InputArray[16];  //[0] is empty
  heartcuttingEndList[2] = InputArray[17];
  heartcuttingEndList[3] = InputArray[18];
  heartcuttingEndList[4] = InputArray[19];
  analysisTotalT = lowestTvalue + HoldT1value + HoldT2value + (Temp1value - lowestTempvalue) / RampSpeed1value + (Temp2value - Temp1value) / RampSpeed2value; //s
  heartcuttingflag = 0;
}
double tempFunction()
{
  Dt = 1;
  if (TotalTime <= ((pumpingTvalue + waitingTvalue + lowestTvalue) * 1000))
  {
    return lowestTempvalue;
  }
  else if (TotalTime <= ((pumpingTvalue + waitingTvalue + lowestTvalue + (Temp1value - lowestTempvalue) / RampSpeed1value) * 1000))
  {
    return lowestTempvalue + RampSpeed1value * (TotalTime / 1000.0 - (pumpingTvalue + waitingTvalue + lowestTvalue));
  }
  else if (TotalTime <= ((pumpingTvalue + waitingTvalue + lowestTvalue + (Temp1value - lowestTempvalue) / RampSpeed1value + HoldT1value) * 1000))
  {
    return Temp1value;
  }
  else if (TotalTime <= ((pumpingTvalue + waitingTvalue + lowestTvalue + (Temp1value - lowestTempvalue) / RampSpeed1value + HoldT1value + (Temp2value - Temp1value) / RampSpeed2value) * 1000))
  {
    return Temp1value + RampSpeed2value * (TotalTime / 1000.0 - (pumpingTvalue + waitingTvalue + lowestTvalue + (Temp1value - lowestTempvalue) / RampSpeed1value + HoldT1value));
  }
  else if (TotalTime <= ((pumpingTvalue + waitingTvalue + lowestTvalue + (Temp1value - lowestTempvalue) / RampSpeed1value + HoldT1value + (Temp2value - Temp1value) / RampSpeed2value + HoldT2value) * 1000))
  {
    return Temp2value;
  }
  else //cleaning
  {
    return 0;
  }
}
double PIDControl(double setPoint, double processValue)
{
  double outPut;
  error = setPoint - processValue;
  integral = integral + (error * Dt);
  derivative = (error - preError) / Dt;
  outPut = (Kp * error) + (Ki * integral) + (Kd * derivative);
  preError = error;
  //file.WriteLine(setPoint.ToString()+"    "+processValue.ToString()+"    "+outPut.ToString());
  return outPut;
}

