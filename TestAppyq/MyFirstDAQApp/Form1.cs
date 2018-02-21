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
        }

        public List<float> x1 = new List<float>();     //1D signal
        public List<float> y1 = new List<float>();
        public List<float> x4 = new List<float>();     //2D signal
        public List<float> y4 = new List<float>();
        public List<float> x_b = new List<float>();     //baseline
        public List<float> y_b = new List<float>();
        public List<float> x_p = new List<float>(); // peakline
        public List<float> y_p = new List<float>();
        public int constant_m = 1; // for SNIP baseline formula
        public int constant_m_end = Convert.ToInt32(1/Math.Sqrt(2)); // for SNIP baseline formula
        public int CONSECUTIVE_SCAN_STEPS = 3; //for peak detection
        public float THRESHOLD = 0.005f; //for peak detection: slope
        public float THRESHOLD_peak = 2f; //for peak detection: slope
        List<int> peaks = new List<int>();//save all the peaks
        List<int> bottoms = new List<int>();//save all the bottoms


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void StartDraw()//start getting signal without click
        {
            TempGraph.f_ClearAllPix();
            TempGraph.f_reXY();
            TempGraph.f_LoadOnePix(ref x1, ref y1, Color.Red, 2);
            TempGraph.f_AddPix(ref x_b, ref y_b, Color.Blue, 2);
            TempGraph.f_AddPix(ref x_p, ref y_p, Color.Green, 2);
        }

        /*******************************************************************************************************************/
        private void RawDataDatFileReader(string filename)
        {
            System.IO.StreamReader Datafile;
            Datafile = new System.IO.StreamReader(filename);
            string[] str = new string[10];
            string line;
            while ((line = Datafile.ReadLine()) != null)
            {
                str = line.Split();
                x1.Add(float.Parse(str[0]));
                double dou1 = float.Parse(str[1]);
                y1.Add((float)dou1);
            }
            Datafile.Close();
        }

        private List<Item> data = new List<Item>();
        class Item
        {
            public int PeakNum { get; set; }
            public float PeakStart { get; set; }
            public float PeakPosition { get; set; }
            public float PeakEnd { get; set; }
            public float Height { get; set; }
            public float Area { get; set; }
            public Item(int num1, float num2, float num3, float num4, float num5, float num6)
            {
                this.PeakNum = num1;
                this.PeakStart = num2;
                this.PeakPosition = num3;
                this.PeakEnd = num4;
                this.Height = num5;
                this.Area = num6;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            x1.Clear();
            y1.Clear();
            x_b.Clear();
            y_b.Clear();
            StartDraw();
            RawDataDatFileReader(FileNameText.Text);
            int SignalLength = x1.Count();
            SignalLengthText.Text = SignalLength.ToString();
            SNIPBaseline();
            TempGraph.f_Refresh();
        }

        /*************************************SNIP Baseline algorithm*************************************/

        private void SNIPBaseline()
        {
            /*
          //initiate y_b & y_close
           for (int j = 0; j < signalAmount; j++)
               {

                   if (y1[j] > -1)
                   {
                       double innerValue = Math.Log(Math.Sqrt(y1[j] + 1) + 1) + 1;
                       float value = (float)Math.Log(innerValue);
                       y_b.Add(value);
                   }
                   else
                   {
                       y_b.Add(0);
                   }

                   y_close.Add(y1[j]);

               }
         */
            int indexX = 0;
            float valueY = 0;
            int size = 0;
            List<float> temp = new List<float>();
            List<float> temp_x_b = new List<float>();
            List<float> temp_y_b = new List<float>();

            detectPeakAndBottom();
            size = bottoms.Count;
            for (int i = 0; i < size; i++)
            {
                indexX = bottoms[i];
                temp_x_b.Add(x1[indexX]);
                valueY = y1[indexX];
                temp_y_b.Add(valueY);
            }
            
           
            //smmooth baseline
                //iteration for 16 times from index 20
            for (int z = 0; z < 30; z++)
            {
                for (int m = constant_m; m < size - constant_m; m++)
                {
                    temp.Add(Math.Min(temp_y_b[m], (temp_y_b[m - constant_m] + temp_y_b[m + constant_m]) / 2));
                   
                }
                for (int n = constant_m; n < size - constant_m; n++)
                {
                    temp_y_b[n] = temp[n - constant_m];
                
                }

            }

            //iteration for 8 times from index 20
            temp.Clear();
         
            for (int t = 0; t < 8; t++)
            {
                for (int p = constant_m; p < size - constant_m; p++)
                {
                    temp.Add(Math.Min(temp_y_b[p], (temp_y_b[p - constant_m_end] + temp_y_b[p + constant_m_end]) / 2));
                    
                }
                for (int q = constant_m; q < size - constant_m; q++)
                {
                    temp_y_b[q] = temp[q - constant_m];
                   
                }

            }

            //make baseline consecutive, get all the coordination of point in between
            int bottomCount = bottoms.Count;
            float k = 0; //slope
            float b = 0; //intersection

            // initialize y_b
            for (int v = 0; v < x1.Count; v++)
            {
                x_b.Add(x1[v]);
                y_b.Add(0);
            }

            //calculate the points before first bottom
            int start = 0;
            for (start = 0; x1[start] <= temp_x_b[0]; start++) y_b[start] = temp_y_b[0];
            //calculate the points before last bottom
            for (int a = 0; a < bottomCount - 1; a++)
            {
                k = (temp_y_b[a + 1] - temp_y_b[a])/ (temp_x_b[a + 1] - temp_x_b[a]);
                b = temp_y_b[a] - k * temp_x_b[a];

                int index = 0;
                while (x1[start + index] <= temp_x_b[a + 1])
                {
                    float value = k * x1[a + index] + b;
                    y_b[a + index] = value;
                    index++;
                }
                start = start + index;


            }
            //calculate the points after last bottom
            for (int p = x1.Count-1; x1[p] >= temp_x_b[(bottomCount-1)]; p--)
            {
                y_b[p] = temp_y_b[bottomCount-1];
            }





        }
        /*************************************************************************************************/
        // peak and bottom detection

        private void detectPeakAndBottom()
        {
            int signalAmount = x1.Count;
            List<float> slopes = new List<float>();
            int size = 0;
            int peakMax = 0; // index of maximum
            int peakStart = 0;
            int peakStop = 0;
            float slope = 0; //current slope
            List<float> values = new List<float>(); //save three consecutive slopes
           
            //calculate the slopes of all scans
            for (int b = 0; b < signalAmount-1; b++)
            {
                float slopeTemp = (float)(y1[b+1]- y1[b])/ (x1[b + 1] - x1[b]);
                slopes.Add(slopeTemp);
            }
            slopes.Add(0);// the slope of the last scan
            size = slopes.Count;


            for (int scan = 0; scan < size - CONSECUTIVE_SCAN_STEPS; scan++)
            {
                slope = slopes[scan];
                if (slope > THRESHOLD)
                {
                    /*
                    * Get the actual and the next slope values.
                    */
                    values.Clear();
                    for (int j = 0; j < CONSECUTIVE_SCAN_STEPS; j++)
                    {
                        if (scan + j >= size) break;
                        values.Add(slopes[scan + j]);
                    }
                    if (valuesAreGreaterThanThreshold(values) && valuesAreIncreasing(values))
                    {
                        //find peak
                        peakStart = scan;
                        peakMax = peakStart;
                        while (slopes[peakMax]>0 && peakMax < size-1)
                        {
                            peakMax++;
                        }
                        peaks.Add(peakMax);

                        //find peakStop
                        peakStop = peakMax;
                        if (peakStop == size - 1) break; //the last scan is a peak
                        while (slopes[peakStop] <= 0 && peakStop < size - 1)
                        {
                            peakStop++;
                        }
                        bottoms.Add(peakStop);
                        scan = peakStop;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            int indX = 0;
            float valY = 0;
            for (int i = 0; i < peaks.Count; i++)
            {
                indX = peaks[i];
                x_p.Add(x1[indX]);
                valY = y1[indX];
                y_p.Add(valY);
            }

        }

        /*************************************************************************************************/
        //sub method for peak detection
        private bool valuesAreGreaterThanThreshold(List<float> values)
        {
            if (values[0] > THRESHOLD && values[1] > THRESHOLD && values[2] > THRESHOLD)
                return true;
            else
                return false;
        }

        private bool valuesAreIncreasing(List<float> values)
        {
            if ((values[0] < values[1]) && (values[1] < values[2]))
                return true;
            else
                return false;

        }



        /*************************************************************************************************/

        //smooth algorithm
        private static int MovingWindowWidth = 15;
        private double[] MovingWindow = new double[MovingWindowWidth - 1];
        private double[] MovingWindow2 = new double[MovingWindowWidth - 1];
        private double Movingaverage(double current, int OneOrTwoD)
        {
            if (OneOrTwoD == 1)
            {
                int CurrentLength = y1.Count;
                if (CurrentLength < MovingWindowWidth - 1)
                {
                    MovingWindow[CurrentLength] = current;
                    float sum = 0;
                    for (int i = 1; i <= CurrentLength; i++)
                    {
                        sum = sum + (float)MovingWindow[CurrentLength - i];
                    }
                    return (sum + current) / (CurrentLength + 1);
                }
                else
                {
                    float sum = 0;
                    for (int i = 0; i < MovingWindowWidth - 1; i++)
                    {
                        sum = sum + (float)MovingWindow[i];
                    }
                    for (int i = 0; i < MovingWindowWidth - 2; i++)
                    {
                        MovingWindow[i] = MovingWindow[i + 1];
                    }
                    MovingWindow[MovingWindowWidth - 2] = current;
                    return (sum + current) / (double)MovingWindowWidth;
                }
            }
            else
            {
                int CurrentLength = y4.Count;
                if (CurrentLength < MovingWindowWidth - 1)
                {
                    MovingWindow2[CurrentLength] = current;
                    float sum = 0;
                    for (int i = 1; i <= CurrentLength; i++)
                    {
                        sum = sum + (float)MovingWindow2[CurrentLength - i];
                    }
                    return (sum + current) / (CurrentLength + 1);
                }
                else
                {
                    float sum = 0;
                    for (int i = 0; i < MovingWindowWidth - 1; i++)
                    {
                        sum = sum + (float)MovingWindow2[i];
                    }
                    for (int i = 0; i < MovingWindowWidth - 2; i++)
                    {
                        MovingWindow2[i] = MovingWindow2[i + 1];
                    }
                    MovingWindow2[MovingWindowWidth - 2] = current;
                    return (sum + current) / (double)MovingWindowWidth;
                }
            }
        }
        private double rt_roundd_snf(double u)
        {
            double y;
            if (Math.Abs(u) < 4.503599627370496E+15)
            {
                if (u >= 0.5)
                {
                    y = Math.Floor(u + 0.5);
                }
                else if (u > -0.5)
                {
                    y = u * 0.0;
                }
                else
                {
                    y = Math.Ceiling(u - 0.5);
                }
            }
            else
            {
                y = u;
            }
            return y;
        }

        private void deriv(List<float> a, List<float> d, int SignalLength)
        {
            int j;
            d.Add(a[1] - a[0]);
            for (j = 0; j < SignalLength - 2; j++)
            {
                d.Add((float)((a[2 + j] - a[j]) / 2.0));
            }
            d.Add(a[SignalLength - 1] - a[SignalLength - 2]);
        }

        private float sum(List<float> x_data, int[] x_size)
        {
            float y;
            int k;
            y = x_data[0];
            for (k = 2; k <= x_size[1]; k++)
            {
                y += x_data[k - 1];
            }
            return y;
        }

        private void rdivide(List<float> x, double y, List<float> z, int SignalLength)
        {
            int i3;
            for (i3 = 0; i3 < SignalLength; i3++)
            {
                z[i3] = (float)(x[i3] / y);
            }
        }

        private void sa(List<float> Y, double smoothwidth, List<float> SmoothY, int SignalLength)
        {
            double w;
            List<float> Y_data = new List<float>();
            int[] Y_size = new int[2];
            int loop_ub;
            int i1;
            double SumPoints;
            List<float> s = new List<float>();
            int halfw;
            int tmp;
            int[] b_Y_size = new int[2];
            int i2;
            w = rt_roundd_snf(smoothwidth);
            Y_size[0] = 1;
            Y_size[1] = (int)w;
            loop_ub = (int)w;
            for (i1 = 0; i1 < loop_ub; i1++)
            {
                Y_data[i1] = Y[i1];
            }

            SumPoints = sum(Y_data, Y_size);
            halfw = (int)rt_roundd_snf(w / 2.0);
            tmp = 0;
            for (loop_ub = 0; loop_ub <= SignalLength - 1 - (int)w; loop_ub++)
            {
                s[(loop_ub + halfw) - 1] = (float)SumPoints;
                SumPoints -= Y[loop_ub];
                SumPoints += Y[loop_ub + (int)w];
                tmp = loop_ub;
            }

            i1 = -(int)w;
            b_Y_size[0] = 1;
            b_Y_size[1] = -i1;
            loop_ub = -i1;
            for (i2 = 0; i2 < loop_ub; i2++)
            {
                Y_data[i2] = Y[(i1 + i2) + SignalLength];
            }

            s[tmp + halfw] = sum(Y_data, b_Y_size);
            rdivide(s, w, SmoothY, SignalLength);

            //  Taper the ends of the signal if ends=1. 
        }

        private void fastsmooth(List<float> Y, double w, double type, List<float> SmoothY, int SignalLength)
        {
            List<float> dv1 = new List<float>();
            List<float> dv2 = new List<float>();
            List<float> dv3 = new List<float>();
            sa(Y, w, SmoothY, SignalLength);
            switch ((int)type)
            {
                case 1:
                    sa(Y, w, SmoothY, SignalLength);
                    break;

                case 2:
                    sa(Y, w, dv1, SignalLength);
                    sa(dv1, w, SmoothY, SignalLength);
                    break;

                case 3:
                    sa(Y, w, dv2, SignalLength);
                    sa(dv2, w, dv3, SignalLength);
                    sa(dv3, w, SmoothY, SignalLength);
                    break;
            }
        }

        void findpeaksG(List<float> x, List<float> y, int SignalLength, double SlopeThreshold, double AmpThreshold, double smoothwidth, double
            peakgroup, double smoothtype, double[] P)
        {
            List<float> dv0 = new List<float>();
            List<float> d = new List<float>();
            if (smoothtype > 3.0)
            {
                smoothtype = 3.0;
            }

            if (smoothtype < 1.0)
            {
                smoothtype = 1.0;
            }

            if (smoothwidth < 1.0)
            {
                smoothwidth = 1.0;
            }

            smoothwidth = rt_roundd_snf(smoothwidth);
            peakgroup = rt_roundd_snf(peakgroup);
            if (smoothwidth > 1.0)
            {
                //deriv(y, dv0, SignalLength);
                deriv(y, d, SignalLength);
                //fastsmooth(dv0, smoothwidth, smoothtype, d, SignalLength);
            }
            else
            {
                deriv(y, d, SignalLength);
            }
            //Change devision to 1 or -1
            for (int ChangeIndex = 0; ChangeIndex < SignalLength; ChangeIndex++)
            {
                if (d[ChangeIndex] < 0)
                {
                    d[ChangeIndex] = -1;
                }
                else
                {
                    d[ChangeIndex] = 1;
                }
            }
            //Peak detection
            List<int> StartPosition = new List<int>();
            List<int> EndPosition = new List<int>();
            List<float> Area = new List<float>();
            List<float> Height = new List<float>();
            int PositionIndex = -1;
            int StartFlag = 0;
            List<int> PeakPosition = new List<int>();
            //Initialization
            for (int initial = 0; initial < SignalLength; initial++)
            {
                StartPosition.Add(0);
                PeakPosition.Add(0);
                EndPosition.Add(0);
                Area.Add(0);
                Height.Add(0);
            }
            for (int xIndex = 1; xIndex < SignalLength - 2; xIndex++)
            {
                if (d[xIndex - 1] * d[xIndex] <= 0)
                {
                    if (((d[xIndex - 1] < 0 && d[xIndex] > 0) || y[xIndex] < 0.5) && StartFlag == 0)
                    {
                        StartPosition[PositionIndex + 1] = xIndex;
                    }
                    else if (d[xIndex - 1] > 0 && d[xIndex] < 0 && y[xIndex] > SlopeThreshold)
                    {
                        PositionIndex++;
                        PeakPosition[PositionIndex] = xIndex;
                        StartFlag = 1;
                    }
                    else if (((d[xIndex - 1] < 0 && d[xIndex] > 0) || y[xIndex] < 0.5) && StartFlag == 1)
                    {
                        EndPosition[PositionIndex] = xIndex;
                        StartPosition[PositionIndex + 1] = xIndex;
                        StartFlag = 0;
                    }
                    else { }
                }
            }

            //Integration
            for (int p1 = 0; p1 <= PositionIndex; p1++)
            {
                for (int p2 = StartPosition[p1]; p2 < EndPosition[p1]; p2++)
                {
                    Area[p1] = (float)(Area[p1] + y[p2] * 0.25);
                }
                Height[p1] = y[PeakPosition[p1]];
            }

            for (int p1 = 0; p1 <= PositionIndex; p1++)
            {
                data.Add(new Item(p1 + 1, x[StartPosition[p1]], x[PeakPosition[p1]], x[EndPosition[p1]], Height[p1], Area[p1]));
            }
        }

        private void TempGraph_Load(object sender, EventArgs e)
        {

        }
    }
}
