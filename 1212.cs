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

        private void flashIndicatorForPWM(int selectPort, Boolean value)
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
        private double tempFunction(double lowTemp, double holdingTime, double rampingSpeed, double rampingTime)
        {
            if (timerDrawI <= holdingTime)
            {
                return lowTemp;
            }
            else if (timerDrawI <= (holdingTime + rampingTime))
            {
                return lowTemp + rampingSpeed * (timerDrawI - holdingTime);
            }
            else
            {
                return lowTemp + rampingSpeed * rampingTime;
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
            timerDraw.Start();//start timer
            Graph1D.f_ClearAllPix();
            TempGraph.f_ClearAllPix();
            Graph1D.f_reXY();
            TempGraph.f_reXY();
            Graph1D.f_LoadOnePix(ref x1, ref y1, Color.Red, 2);
            TempGraph.f_LoadOnePix(ref x2, ref y2, Color.Red, 2);
            TempGraph.f_AddPix(ref x3, ref y3, Color.Blue, 2);
        }
        private int SignalOnFlag=0;
        private void StartGetSignal()//start getting signal without click
        {
            timerDraw.Start();//start timer
            Graph1D.f_ClearAllPix();
            TempGraph.f_ClearAllPix();
            Graph1D.f_reXY();
            TempGraph.f_reXY();
            Graph1D.f_LoadOnePix(ref x1, ref y1, Color.Red, 2);
            TempGraph.f_LoadOnePix(ref x2, ref y2, Color.Red, 2);
            TempGraph.f_AddPix(ref x3, ref y3, Color.Blue, 2);
        }
        private void zGraphTest_Load(object sender, EventArgs e)
        {
        }
        private void zGraph1_Load(object sender, EventArgs e)
        {

        }
        private float timerDrawI = 0;      //declare the parameter of drawing
        private const double baseLine = 1.4;//loop baseline voltage=1.4v
        private void timerDraw_Tick(object sender, EventArgs e)//start timer and draw
        {
            double analogDataIn=analogIn1()+baseLine;
            //double setTemp = tempFunction(25, 10, 10, 10);
            double setTemp = 0;
            double actualTemp = analogIn2()*175000/7+35000;//thermal couple:25C voltage=0mv, 200C voltage=7mv
            txtAnalogIn.Text = analogDataIn.ToString();//display in textbox
            x1.Add(timerDrawI);
            y1.Add((float)analogDataIn);
            x2.Add(timerDrawI);
            y2.Add((float)setTemp);
            x3.Add(timerDrawI);
            y3.Add((float)actualTemp);
            timerDrawI =(float)(timerDrawI+0.25);//for each count the x add 0.1
            Graph1D.f_Refresh();//sampling
            TempGraph.f_Refresh();
        }

/*******************************************************************************************************************/
        
        private void overallStart_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
            startTime = System.DateTime.Now;
        }

        private DateTime startTime;

        private void timerMenu_Tick(object sender, EventArgs e)//flow control loop
        {
            //temp graph
            double setTemp = 0;
            float TempTime = (float)System.DateTime.Now.Subtract(startTime).TotalMilliseconds;
            double actualTemp = analogIn2() * 175000 / 7 + 35000;//thermal couple:25C voltage=0mv, 200C voltage=7mv
            x2.Add(TempTime);
            y2.Add((float)setTemp);
            x3.Add(TempTime);
            y3.Add((float)actualTemp);
            TempGraph.f_Refresh();

            //ports control
            double pumpingT = float.Parse(pumpingTime.Text);
            double waitingT = float.Parse(waitingTime.Text);
            double preconHighT = float.Parse(preconHighTime.Text);
            double preconLowT = float.Parse(preconLowTime.Text);
            timeUsed.Text = System.DateTime.Now.Subtract(startTime).TotalSeconds.ToString();// time has been used
            if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < (pumpingT * 1000))
            {
                digitalOutHigh(12); pumpIndicator.BackColor = Color.Green;
                digitalOutHigh(0); valveIndicator1.BackColor = Color.Green;
                digitalOutHigh(4);columnIndicator.BackColor = Color.Green;
                //indicator bars, pumping progress indicator range from 0-100 while analyze bar not change
                pumpProgress.Value = (int)((System.DateTime.Now.Subtract(startTime).TotalMilliseconds) / (pumpingT * 10));
                analyzeProgress.Value = 0;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingT + waitingT) * 1000))
            {
                digitalOutLow(12); pumpIndicator.BackColor = Color.Gray;
                digitalOutLow(0); valveIndicator1.BackColor = Color.Gray;
                pumpProgress.Value = 100;
                analyzeProgress.Value = 0;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingT + waitingT + preconHighT) * 1000))
            {
                pumpProgress.Value = 100;
                digitalOutLow(12); pumpIndicator.BackColor = Color.Gray;
                digitalOutLow(0); valveIndicator1.BackColor = Color.Gray;
                digitalOutHigh(13); preconOnIndicator1.BackColor = Color.Green;
                digitalOutHigh(1); preconHighIndicator1.BackColor = Color.Green;
            }
            else if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds < ((pumpingT + waitingT + preconHighT + preconLowT) * 1000))
            {
                digitalOutLow(12); pumpIndicator.BackColor = Color.Gray;
                digitalOutLow(0); valveIndicator1.BackColor = Color.Gray;
                digitalOutLow(13); preconOnIndicator1.BackColor = Color.Gray;
                pwmout(50,1); preconHighIndicator1.BackColor = Color.Gray;
                flashIndicatorForPWM(1, System.DateTime.Now.Subtract(startTime).TotalMilliseconds % 2000 < 1000);
            }
            else
            {
                initial_set_Ports_Low();
                return;
            }
            if (System.DateTime.Now.Subtract(startTime).TotalMilliseconds - ((pumpingT + waitingT) * 1000) > 0 && SignalOnFlag==0)
            {
                StartGetSignal();
                SignalOnFlag = 1;
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
            //TempGraph initial
            TempGraph.f_ClearAllPix();
            TempGraph.f_reXY();
            TempGraph.f_LoadOnePix(ref x2, ref y2, Color.Red, 2);
            TempGraph.f_AddPix(ref x3, ref y3, Color.Blue, 2);
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
            timerDraw.Stop();
        }
    }
}
