//------------------------Library-------------------------------
#include <SPI.h>
#include <SoftwareSerial.h>
#include <math.h>
#include <ads1262.h>            //ADC module
#include <Adafruit_MCP4725.h>   //DAC module

//------------------------Class-------------------------------

ads1262 PC_ADS1262;            //ADC module
Adafruit_MCP4725 dac;          //DAC module
#define PIN_ADS1262_START 42
#define PIN_ADS1262_CS 44
#define PIN_ADS1262_DRDY 46
#define PIN_ADS1262_PWDN 48

//ports defination
const int PrimaryValves = 23; //valve1
const int PreconHL = 31; //precon H1
const int PreconControl = 5;  //precon On1
const int FanPort = 33; //fan
const int ColumnPort = 4;  //column
const int P0_5 = 34;
const int Precon2HL = 35; //precon H2
const int Precon2Control = 6; //precon On2
const int SecondaryValve = 25; //valve2
const int P1_1 = 11;
const int PumpPort = 29; //pump

//User input
double InputArray[20];
double analysisTotalT;  //unit:s
int heartcuttingNumber = 0;
int heartcuttingflag = 0;
double pumpingTvalue = 5;      //unit:s
double SetPressurevalue = 2;
double waitingTvalue = 5;      //unit:s
double preconHighTvalue = 0.6; //unit:s
double preconLowTvalue = 5;    //unit:s
double lowestTempvalue = 30;
double lowestTvalue = 30;      //unit:s
double Temp1value = 35;
double HoldT1value = 0;       //unit:s
double RampSpeed1value = 0.167;   //c/s
double Temp2value = 40;
double HoldT2value = 0;       //unit:s
double RampSpeed2value = 0.5;
double cleaningTvalue = 60;    //unit:s
double cleaningPvalue = 5;     //unit:s
double cleaningHvalue = 0.6;       //unit:s
double CoolingTvalue = 30;    //unit:s
double heartcuttingStartList[6] = {0, 30, 50, 70}; //[0] is empty
double heartcuttingEndList[6] = {0, 35, 55, 75};  //[0] is empty
double thresholdvalue;

//timer
unsigned long Time_start;
unsigned long Time_now;
unsigned long TotalTime = 0;
unsigned long PreviousTotalTime = 0;
unsigned long Time_stop = 0;
unsigned long TotalStopTime = 0;
boolean StartTestFlag = false;

//serial event
String inputString = "";         // a string to hold incoming data
boolean stringComplete = true;   // whether the string is complete
char InputType;                  // i---int, d---double, other---char

//signals
double ActualTempVoltage = 0;
double ActualTemp = 25;
double PIDSignal1 = 0;
double PIDSignal2 = 0;
double SetTemp = 25;
double ActualPressure = 2;

//PID feedbacks
double error = 0;
double integral = 0;
double derivative = 0;
double preError = 0;
double Dt = 1;
double Kp = 0.3;
double Ki = 0.01;
double Kd = 0;
double PIDFeedbackOutput = 0;
double PIDFeedbackPersentage = 0;



