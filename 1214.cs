using NationalInstruments;
using NationalInstruments.DAQmx;
//using NationalInstruments.UI;
//using NationalInstruments.UI.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MyFirstDAQApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initial_set_Ports_Low();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*parameters defination*/
        #region **List data**
        public List<float> x1 = new List<float>();
        public List<float> y1 = new List<float>();
        public List<float> x2 = new List<float>();
        public List<float> y2 = new List<float>();
        public List<float> x3 = new List<float>();
        public List<float> y3 = new List<float>();
        #endregion
        /*ports defination*/
        private string P0_0 = "dev1/port0/line0"; //valve1
        private string P0_1 = "dev1/port0/line1"; //precon On1
        private string P0_2 = "dev1/port0/line2";
        private string P0_3 = "dev1/port0/line3";
        private string P0_4 = "dev1/port0/line4"; //column
        private string P0_5 = "dev1/port0/line5";
        private string P0_6 = "dev1/port0/line6"; //precon H2
        private string P0_7 = "dev1/port0/line7"; //precon On2
        private string P1_0 = "dev1/port1/line0"; //valve2
        private string P1_1 = "dev1/port1/line1";
        private string P1_2 = "dev1/port1/line2"; //pump
        private string P1_3 = "dev1/port1/line3"; //precon H1
        /*packed methods*/
        private void digitalOutHigh(int selectPort)
        {
            switch (selectPort)
            {
                case 0:
                    Task digitalOutTask0 = new Task();
                    DOChannel DOChannel0;
                    DOChannel0 = digitalOutTask0.DOChannels.CreateChannel(P0_0, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer0 = new DigitalSingleChannelWriter(digitalOutTask0.Stream);
                    writer0.WriteSingleSamplePort(true, 1);
                    break;
                case 1:
                    Task digitalOutTask1 = new Task();
                    DOChannel DOChannel1;
                    DOChannel1 = digitalOutTask1.DOChannels.CreateChannel(P0_1, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer1 = new DigitalSingleChannelWriter(digitalOutTask1.Stream);
                    writer1.WriteSingleSamplePort(true, -1);
                    break;
                case 2:
                    Task digitalOutTask2 = new Task();
                    DOChannel DOChannel2;
                    DOChannel2 = digitalOutTask2.DOChannels.CreateChannel(P0_2, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer2 = new DigitalSingleChannelWriter(digitalOutTask2.Stream);
                    writer2.WriteSingleSamplePort(true, -1);
                    break;
                case 3:
                    Task digitalOutTask3 = new Task();
                    DOChannel DOChannel3;
                    DOChannel3 = digitalOutTask3.DOChannels.CreateChannel(P0_3, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer3 = new DigitalSingleChannelWriter(digitalOutTask3.Stream);
                    writer3.WriteSingleSamplePort(true, -1);
                    break;
                case 4:
                    Task digitalOutTask4 = new Task();
                    DOChannel DOChannel4;
                    DOChannel4 = digitalOutTask4.DOChannels.CreateChannel(P0_4, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer4 = new DigitalSingleChannelWriter(digitalOutTask4.Stream);
                    writer4.WriteSingleSamplePort(true, -1);
                    break;
                case 5:
                    Task digitalOutTask5 = new Task();
                    DOChannel DOChannel5;
                    DOChannel5 = digitalOutTask5.DOChannels.CreateChannel(P0_5, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer5 = new DigitalSingleChannelWriter(digitalOutTask5.Stream);
                    writer5.WriteSingleSamplePort(true, -1);
                    break;
                case 6:
                    Task digitalOutTask6 = new Task();
                    DOChannel DOChannel6;
                    DOChannel6 = digitalOutTask6.DOChannels.CreateChannel(P0_6, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer6 = new DigitalSingleChannelWriter(digitalOutTask6.Stream);
                    writer6.WriteSingleSamplePort(true, -1);
                    break;
                case 7:
                    Task digitalOutTask7 = new Task();
                    DOChannel DOChannel7;
                    DOChannel7 = digitalOutTask7.DOChannels.CreateChannel(P0_7, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer7 = new DigitalSingleChannelWriter(digitalOutTask7.Stream);
                    writer7.WriteSingleSamplePort(true, -1);
                    break;
                case 10:
                    Task digitalOutTask10 = new Task();
                    DOChannel DOChannel10;
                    DOChannel10 = digitalOutTask10.DOChannels.CreateChannel(P1_0, "Port1",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer10 = new DigitalSingleChannelWriter(digitalOutTask10.Stream);
                    writer10.WriteSingleSamplePort(true, -1);
                    break;
                case 11:
                    Task digitalOutTask11 = new Task();
                    DOChannel DOChannel11;
                    DOChannel11 = digitalOutTask11.DOChannels.CreateChannel(P1_1, "Port1",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer11 = new DigitalSingleChannelWriter(digitalOutTask11.Stream);
                    writer11.WriteSingleSamplePort(true, -1);
                    break;
                case 12:
                    Task digitalOutTask12 = new Task();
                    DOChannel DOChannel12;
                    DOChannel12 = digitalOutTask12.DOChannels.CreateChannel(P1_2, "Port1",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer12 = new DigitalSingleChannelWriter(digitalOutTask12.Stream);
                    writer12.WriteSingleSamplePort(true, -1);
                    break;
                case 13:
                    Task digitalOutTask13 = new Task();
                    DOChannel DOChannel13;
                    DOChannel13 = digitalOutTask13.DOChannels.CreateChannel(P1_3, "Port1",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer13 = new DigitalSingleChannelWriter(digitalOutTask13.Stream);
                    writer13.WriteSingleSamplePort(true, -1);
                    break;
            }
        }
        private void digitalOutLow(int selectPort)
        {
            switch (selectPort)
            {
                case 0:
                    Task digitalOutTask0 = new Task();
                    DOChannel DOChannel0;
                    DOChannel0 = digitalOutTask0.DOChannels.CreateChannel(P0_0, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer0 = new DigitalSingleChannelWriter(digitalOutTask0.Stream);
                    writer0.WriteSingleSamplePort(true, 0);
                    break;
                case 1:
                    Task digitalOutTask1 = new Task();
                    DOChannel DOChannel1;
                    DOChannel1 = digitalOutTask1.DOChannels.CreateChannel(P0_1, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer1 = new DigitalSingleChannelWriter(digitalOutTask1.Stream);
                    writer1.WriteSingleSamplePort(true, 0);
                    break;
                case 2:
                    Task digitalOutTask2 = new Task();
                    DOChannel DOChannel2;
                    DOChannel2 = digitalOutTask2.DOChannels.CreateChannel(P0_2, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer2 = new DigitalSingleChannelWriter(digitalOutTask2.Stream);
                    writer2.WriteSingleSamplePort(true, 0);
                    break;
                case 3:
                    Task digitalOutTask3 = new Task();
                    DOChannel DOChannel3;
                    DOChannel3 = digitalOutTask3.DOChannels.CreateChannel(P0_3, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer3 = new DigitalSingleChannelWriter(digitalOutTask3.Stream);
                    writer3.WriteSingleSamplePort(true, 0);
                    break;
                case 4:
                    Task digitalOutTask4 = new Task();
                    DOChannel DOChannel4;
                    DOChannel4 = digitalOutTask4.DOChannels.CreateChannel(P0_4, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer4 = new DigitalSingleChannelWriter(digitalOutTask4.Stream);
                    writer4.WriteSingleSamplePort(true, 0);
                    break;
                case 5:
                    Task digitalOutTask5 = new Task();
                    DOChannel DOChannel5;
                    DOChannel5 = digitalOutTask5.DOChannels.CreateChannel(P0_5, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer5 = new DigitalSingleChannelWriter(digitalOutTask5.Stream);
                    writer5.WriteSingleSamplePort(true, 0);
                    break;
                case 6:
                    Task digitalOutTask6 = new Task();
                    DOChannel DOChannel6;
                    DOChannel6 = digitalOutTask6.DOChannels.CreateChannel(P0_6, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer6 = new DigitalSingleChannelWriter(digitalOutTask6.Stream);
                    writer6.WriteSingleSamplePort(true, 0);
                    break;
                case 7:
                    Task digitalOutTask7 = new Task();
                    DOChannel DOChannel7;
                    DOChannel7 = digitalOutTask7.DOChannels.CreateChannel(P0_7, "Port0",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer7 = new DigitalSingleChannelWriter(digitalOutTask7.Stream);
                    writer7.WriteSingleSamplePort(true, 0);
                    break;
                case 10:
                    Task digitalOutTask10 = new Task();
                    DOChannel DOChannel10;
                    DOChannel10 = digitalOutTask10.DOChannels.CreateChannel(P1_0, "Port1",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer10 = new DigitalSingleChannelWriter(digitalOutTask10.Stream);
                    writer10.WriteSingleSamplePort(true, 0);
                    break;
                case 11:
                    Task digitalOutTask11 = new Task();
                    DOChannel DOChannel11;
                    DOChannel11 = digitalOutTask11.DOChannels.CreateChannel(P1_1, "Port1",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer11 = new DigitalSingleChannelWriter(digitalOutTask11.Stream);
                    writer11.WriteSingleSamplePort(true, 0);
                    break;
                case 12:
                    Task digitalOutTask12 = new Task();
                    DOChannel DOChannel12;
                    DOChannel12 = digitalOutTask12.DOChannels.CreateChannel(P1_2, "Port1",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer12 = new DigitalSingleChannelWriter(digitalOutTask12.Stream);
                    writer12.WriteSingleSamplePort(true, 0);
                    break;
                case 13:
                    Task digitalOutTask13 = new Task();
                    DOChannel DOChannel13;
                    DOChannel13 = digitalOutTask13.DOChannels.CreateChannel(P1_3, "Port1",
                        ChannelLineGrouping.OneChannelForEachLine);
                    DigitalSingleChannelWriter writer13 = new DigitalSingleChannelWriter(digitalOutTask13.Stream);
                    writer13.WriteSingleSamplePort(true, 0);
                    break;
            }
        }
        private double analogIn1()
        {
            Task analogInTask = new Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("dev1/ai0", "myAIChannel",
                AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);
            double analogDataIn = reader.ReadSingleSample();
            return analogDataIn;
        }
        private double analogIn2()
        {
            Task analogInTask = new Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("dev1/ai1", "myAIChannel",
                AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);
            double analogDataIn = reader.ReadSingleSample();
            return analogDataIn;
        }

       /* private void flashIndicatorForPWM(int selectPort, Boolean value)
        {
            if (value == true)
            {
                if (selectPort == 1)
                {
                    preconOnIndicator1.BackColor = Color.Green;
                }
                else if (selectPort == 4)
                {
                    preconOnIndicator2.BackColor = Color.Green;
                }
                else if (selectPort == 7)
                {
                    columnIndicator.BackColor = Color.Green;
                }
                else { }
            }
            else
            {
                if (selectPort == 1)
                {
                    preconOnIndicator1.BackColor = Color.Gray;
                }
                else if (selectPort == 4)
                {
                    preconOnIndicator2.BackColor = Color.Gray;
                }
                else if (selectPort == 7)
                {
                    columnIndicator.BackColor = Color.Gray;
                }
                else { }
            }

        }
        */
        private void pwmout(int percentage,int selectPort)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i < percentage)
                {
                    digitalOutHigh(selectPort);
                    System.Threading.Thread.Sleep(2);
                }
                else
                {
                    digitalOutLow(selectPort);
                    System.Threading.Thread.Sleep(2);
                }
            }
        }

        //private double psetPoint = 0;
        //private double pprocessValue = 0;
        //private double poutPut = 0;
        private double error = 0;
        private double integral = 0;
        private double derivative = 0;
        private double preError = 0;
     /*   public double setPoint
        {
            get { return psetPoint; }
            set
            {
                psetPoint = value;
            }
        }
        public double processValue
        {
            get { return pprocessValue; }
            set
            {
                pprocessValue = value;
            }
        }
        public double outPut
        {
            get { return poutPut; }
            set
            {
                poutPut = value;
            }
        }*/
        private double tempFunction()
        {
            if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds <= ((pumpingTvalue + waitingTvalue + lowestTvalue) * 1000))
            {
                return lowestTempvalue;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds <= ((pumpingTvalue + waitingTvalue + lowestTvalue + (HighestTempvalue - lowestTempvalue) / RampSpeedvalue) * 1000))
            {
                return lowestTempvalue + RampSpeedvalue * (System.DateTime.Now.Subtract(startTime).TotalMilliseconds / 1000 - (pumpingTvalue + waitingTvalue + lowestTvalue));
            }
            else
            {
                return HighestTempvalue;
            }
        }

        private double Dt = 100;
        private double Kp = 0.04;
        private double Ki = 0.03;
        private double Kd = 0.06;
        private double PIDControl(double setPoint, double processValue)
        {
            double outPut;
            error = setPoint - processValue;
            integral = integral + (error * Dt);
            derivative = (error - preError) / Dt;
            outPut = (Kp * error) + (Ki * integral) + (Kd * derivative);
            preError = error;
            return outPut;
        }
        
/*******************************************************************************************************************/
        private void btnGetAnalogIn_Click(object sender, EventArgs e)//start the timer when click the button
        {
            timerDrawSignal.Start();//start timer
            Graph1D.f_ClearAllPix();
            TempGraph.f_ClearAllPix();
            Graph1D.f_reXY();
            TempGraph.f_reXY();
            Graph1D.f_LoadOnePix(ref x1, ref y1, Color.Red, 2);
            TempGraph.f_LoadOnePix(ref x2, ref y2, Color.Red, 2);
            TempGraph.f_AddPix(ref x3, ref y3, Color.Blue, 2);
        }
        private void StartGetSignal()//start getting signal without click
        {
            timerDrawSignal.Start();//start timer
            Graph1D.f_ClearAllPix();
            Graph1D.f_reXY();
            Graph1D.f_LoadOnePix(ref x1, ref y1, Color.Red, 2);
        }
        private void StartGetTemp()//start getting signal without click
        {
            timerDrawTemp.Start();//start timer
            TempGraph.f_ClearAllPix();
            TempGraph.f_reXY();
            TempGraph.f_LoadOnePix(ref x2, ref y2, Color.Red, 2);
            TempGraph.f_AddPix(ref x3, ref y3, Color.Blue, 2);
        }
        private void zGraphTest_Load(object sender, EventArgs e)
        {
        }
        private void zGraph1_Load(object sender, EventArgs e)
        {

        }
        private float DrawSingalIndex = 0;      //declare the parameter of drawing
        private float DrawTempIndex = 0;
        private const double baseLine = 1.4;//loop baseline voltage=1.4v
        private void timerDrawSignal_Tick(object sender, EventArgs e)//start timer and draw
        {
            double analogDataIn=analogIn1()+baseLine;
            txtAnalogIn.Text = analogDataIn.ToString();//display in textbox
            x1.Add(DrawSingalIndex);
            y1.Add((float)analogDataIn);
            DrawSingalIndex = (float)(DrawSingalIndex + 0.25);//for each count the x add 0.1
            Graph1D.f_Refresh();//sampling
        }
        private void timerDrawTemp_Tick(object sender, EventArgs e)//start timer and draw
        {
            double setTemp = tempFunction();
            double actualTemp = analogIn2() * 175000 / 7 + 35000;//thermal couple:25C voltage=0mv, 200C voltage=7mv
            x2.Add(DrawTempIndex);
            y2.Add((float)setTemp);
            x3.Add(DrawTempIndex);
            y3.Add((float)actualTemp);
            DrawTempIndex = (float)(DrawTempIndex + 0.25);//for each count the x add 0.1
            TempGraph.f_Refresh();
        }

        /*******************************************************************************************************************/

        private void overallStart_Click(object sender, EventArgs e)
        {
            x1.Clear();
            x2.Clear();
            x3.Clear();
            y1.Clear();
            y2.Clear();
            y3.Clear();
            initial_set_Ports_Low();
            DrawSingalIndex = 0;
            DrawTempIndex = 0;
            SignalOnFlag = 0;
            heartcuttingNumber = 0;
            Graph1D.f_ClearAllPix();
            TempGraph.f_ClearAllPix();
            Graph1D.f_reXY();
            TempGraph.f_reXY();
            timerMenu.Start();
            StartGetTemp();
            startTime = System.DateTime.Now;
            //ports control
            pumpingTvalue = float.Parse(pumpingTime.Text);                //s
            waitingTvalue = float.Parse(waitingTime.Text);                //s
            preconHighTvalue = float.Parse(preconHighTime.Text);          //s
            preconLowTvalue = float.Parse(preconLowTime.Text);            //s
            lowestTempvalue = float.Parse(lowestTemp.Text);               //C
            lowestTvalue = float.Parse(lowestHold.Text) * 60;             //s
            HighestTempvalue = float.Parse(highestTemp.Text);             //C
            HighestTvalue = float.Parse(highestHold.Text) * 60;           //s
            RampSpeedvalue = float.Parse(rampSpeed.Text) / 60;            //c/s
            analysisTotalT = lowestTvalue + HighestTvalue + (HighestTempvalue - lowestTempvalue) / RampSpeedvalue; //s
            cleaningPvalue = float.Parse(cleaningPreconTime.Text);               //s
            cleaningTvalue = float.Parse(cleaningTotalTime.Text) * 60;           //s
            if (Start1.Text != "" && float.Parse(Start1.Text) < float.Parse(End1.Text))
            {
                heartcuttingStartList[1] = float.Parse(Start1.Text);             //s
                heartcuttingEndList[1] = float.Parse(End1.Text);                 //s
                heartcuttingNumber++;
            }
            if (Start2.Text != "" && float.Parse(Start2.Text) > heartcuttingEndList[1] && float.Parse(Start2.Text) < float.Parse(End2.Text))
            {
                heartcuttingStartList[2] = float.Parse(Start2.Text);             //s
                heartcuttingEndList[2] = float.Parse(End2.Text);                 //s
                heartcuttingNumber++;
            }
            if (Start3.Text != "" && float.Parse(Start3.Text) > heartcuttingEndList[2] && float.Parse(Start3.Text) < float.Parse(End3.Text))
            {
                heartcuttingStartList[3] = float.Parse(Start3.Text);             //s
                heartcuttingEndList[3] = float.Parse(End3.Text);                 //s
                heartcuttingNumber++;
            }
            if (Start4.Text != "" && float.Parse(Start4.Text) > heartcuttingEndList[3] && float.Parse(Start4.Text) < float.Parse(End4.Text))
            {
                heartcuttingStartList[4] = float.Parse(Start4.Text);             //s
                heartcuttingEndList[4] = float.Parse(End4.Text);                 //s
                heartcuttingNumber++;
            }
            if (Start5.Text != "" && float.Parse(Start5.Text) > heartcuttingEndList[4] && float.Parse(Start5.Text) < float.Parse(End5.Text))
            {
                heartcuttingStartList[5] = float.Parse(Start5.Text);             //s
                heartcuttingEndList[5] = float.Parse(End5.Text);                 //s
                heartcuttingNumber++;
            }
        }

        private DateTime startTime;
        private int SignalOnFlag = 0;
        private double analysisTotalT;
        private int ColumnPWMPersentage = 50;
        private int heartcuttingNumber = 0;
        //User input
        private double pumpingTvalue;
        private double waitingTvalue;
        private double preconHighTvalue;
        private double preconLowTvalue;
        private double lowestTempvalue;
        private double lowestTvalue;
        private double HighestTempvalue;
        private double HighestTvalue;
        private double RampSpeedvalue;
        private double cleaningTvalue;
        private double cleaningPvalue;
        private double[] heartcuttingStartList = new double[6];   //[0] is empty
        private double[] heartcuttingEndList = new double[6];     //[0] is empty

        private void timerMenu_Tick(object sender, EventArgs e)//flow control loop
        {
            timeUsed.Text = System.DateTime.Now.Subtract(startTime).TotalSeconds.ToString();// time has been used
            //1D
            if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < (pumpingTvalue * 1000))
            {
                pumpProgress.Value = (int)((System.DateTime.Now.Subtract(startTime).TotalMilliseconds) / (pumpingTvalue * 10));
                digitalOutHigh(12); pumpIndicator.BackColor = Color.Green;
                digitalOutHigh(0); valveIndicator1.BackColor = Color.Green;
                pwmout(ColumnPWMPersentage,4); columnIndicator.BackColor = Color.Pink;
                //indicator bars, pumping progress indicator range from 0-100 while analyze bar not change
                analyzeProgress.Value = 0;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingTvalue + waitingTvalue) * 1000))
            {
                digitalOutLow(12); pumpIndicator.BackColor = Color.Gray;
                digitalOutLow(0); valveIndicator1.BackColor = Color.Gray;
                pwmout(ColumnPWMPersentage, 4); columnIndicator.BackColor = Color.Pink;
                pumpProgress.Value = 100;
                analyzeProgress.Value = 0;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingTvalue + waitingTvalue + preconHighTvalue) * 1000))
            {
                if (SignalOnFlag == 0)
                {
                    StartGetSignal();
                    SignalOnFlag = 1;
                }
                pumpProgress.Value = 100;
                analyzeProgress.Value = (int)(((System.DateTime.Now.Subtract(startTime).TotalMilliseconds) - (pumpingTvalue + waitingTvalue) * 1000) / (analysisTotalT * 10));
                digitalOutLow(12); pumpIndicator.BackColor = Color.Gray;
                digitalOutLow(0); valveIndicator1.BackColor = Color.Gray;
                digitalOutHigh(13); preconHighIndicator1.BackColor = Color.Green;
                digitalOutHigh(1); preconOnIndicator1.BackColor = Color.Green;
                pwmout(ColumnPWMPersentage, 4); columnIndicator.BackColor = Color.Pink;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingTvalue + waitingTvalue + preconHighTvalue + preconLowTvalue) * 1000))
            {
                analyzeProgress.Value = (int)(((System.DateTime.Now.Subtract(startTime).TotalMilliseconds) - (pumpingTvalue + waitingTvalue) * 1000) / (analysisTotalT * 10));
                digitalOutLow(12); pumpIndicator.BackColor = Color.Gray;
                digitalOutLow(0); valveIndicator1.BackColor = Color.Gray;
                digitalOutLow(13); preconHighIndicator1.BackColor = Color.Gray;
                pwmout(50, 1); preconOnIndicator1.BackColor = Color.Yellow;
                pwmout(ColumnPWMPersentage, 4); columnIndicator.BackColor = Color.Pink;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingTvalue + waitingTvalue + analysisTotalT) * 1000))
            {
                analyzeProgress.Value = (int)(((System.DateTime.Now.Subtract(startTime).TotalMilliseconds) - (pumpingTvalue + waitingTvalue) * 1000) / (analysisTotalT * 10));
                digitalOutLow(1); preconOnIndicator1.BackColor = Color.Gray;
                pwmout(ColumnPWMPersentage, 4); columnIndicator.BackColor = Color.Pink;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingTvalue + waitingTvalue + analysisTotalT + cleaningPvalue) * 1000))
            {
                cleaningProcess.Value = (int)(((System.DateTime.Now.Subtract(startTime).TotalMilliseconds) - (pumpingTvalue + waitingTvalue + analysisTotalT) * 1000) / (cleaningTvalue * 10));
                analyzeProgress.Value = 100;
                digitalOutLow(4); columnIndicator.BackColor = Color.Gray;
                pwmout(50, 1); preconOnIndicator1.BackColor = Color.Yellow;
                //flashIndicatorForPWM(1, System.DateTime.Now.Subtract(startTime).TotalMilliseconds % 2000 < 1000);
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingTvalue + waitingTvalue + analysisTotalT + cleaningTvalue) * 1000))
            {
                digitalOutLow(1); preconOnIndicator1.BackColor = Color.Gray;
                cleaningProcess.Value = (int)(((System.DateTime.Now.Subtract(startTime).TotalMilliseconds) - (pumpingTvalue + waitingTvalue + analysisTotalT) * 1000) / (cleaningTvalue * 10));
            }
            else
            {
                cleaningProcess.Value = 100;
                initial_set_Ports_Low();
                timerMenu.Stop();
                timerDrawSignal.Stop();
                timerDrawTemp.Stop();
                return;
            }

            //2D
            if (heartcuttingNumber > 0)
            {
                if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < (pumpingTvalue * 1000))
                {
                    if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < (preconHighTvalue * 1000))
                    {
                        digitalOutHigh(6); preconHighIndicator2.BackColor = Color.Green;
                        digitalOutHigh(7); preconOnIndicator2.BackColor = Color.Green;
                    }
                    else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((preconHighTvalue + preconLowTvalue) * 1000))
                    {
                        digitalOutLow(6); preconHighIndicator2.BackColor = Color.Gray;
                        pwmout(50, 7); preconOnIndicator2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        digitalOutLow(7); preconOnIndicator2.BackColor = Color.Gray;
                    }
                }
                
            }
        }
        private void initial_set_Ports_Low()
        {
            for (int i = 0; i < 8; i++)
            {
                digitalOutLow(i);
            }
            digitalOutLow(10);
            digitalOutLow(11);
            digitalOutLow(12);
            digitalOutLow(13);
            pumpIndicator.BackColor = Color.Gray;//clear all expected
            valveIndicator1.BackColor = Color.Gray;
            preconOnIndicator1.BackColor = Color.Gray;
            preconHighIndicator1.BackColor = Color.Gray;
            columnIndicator.BackColor = Color.Gray;
            valvaIndicator2.BackColor = Color.Gray;
            preconOnIndicator2.BackColor = Color.Gray;
            preconHighIndicator2.BackColor = Color.Gray;
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            Task analogInTask = new Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("dev1/ai0", "myAIChannel",
            AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);
            double[] test1 = reader.ReadMultiSample(-1);
            double procedureTime = System.DateTime.Now.Subtract(start).TotalMilliseconds;
            textBox1.Text = procedureTime.ToString();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timerMenu.Stop();
            timerDrawSignal.Stop();
            timerDrawTemp.Stop();
        }
    }
}
