using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstDAQApp
{
    public class VOCS
    {
        public string VOCName { set; get; }
        public string CASNum { set; get; }
        public double IonizationPotiential { set; get; }
        public double BP { set; get; }
        public double MolecularWeight { set; get; }
        public VOCS()
        {
            VOCName = "";
            CASNum = "";
            IonizationPotiential = 0;
            BP = 0;
            MolecularWeight = 0;
        }
        public VOCS(string name, string number, double ion, double bp, double weight)
        {
            VOCName = name;
            CASNum = number;
            IonizationPotiential = ion;
            BP = bp;
            MolecularWeight = weight;
        }
    }
    public class METHODS
    {
        public List<string> VOCList { set; get; }
        public List<double> VOCRetentionTime { set; get; }
        public string TheCalibration {set;get;}
        public List<string> CalibrationVOCList { set; get; }
        public double lowestTempvalue { set; get; }
        public double lowestTvalue { set; get; }
        public double HighestTempvalue { set; get; }
        public double HighestTvalue { set; get; }
        public double RampSpeedvalue { set; get; }
        public double[] heartcuttingStartList { set; get; }  //[0] is empty
        public double[] heartcuttingEndList { set; get; }     //[0] is empty
        public int heartcuttingNumber { set; get; }

        public METHODS()
        {
            VOCList = new List<string>();
            VOCRetentionTime = new List<double>();
            TheCalibration = "";
            CalibrationVOCList = new List<string>();
            lowestTempvalue = 0;
            lowestTvalue = 0;
            HighestTempvalue = 0;
            HighestTvalue = 0;
            RampSpeedvalue = 0;
            heartcuttingStartList = new double[6];
            heartcuttingEndList = new double[6];
            heartcuttingNumber = 0;
        }
        public METHODS(List<string> vocs, List<double> vocretention, string thecali, List<string> calivocs, double lowest, double lowesttime, double highest, double highesttime, double ramp, double[] heartstart, double[] heartend, int hnumber)
        {
            VOCList = vocs;
            VOCRetentionTime = vocretention;
            TheCalibration = thecali;
            CalibrationVOCList = calivocs;
            lowestTempvalue = lowest;
            lowestTvalue = lowesttime;
            HighestTempvalue = highest;
            HighestTvalue = highesttime;
            RampSpeedvalue = ramp;
            heartcuttingStartList = heartstart;
            heartcuttingEndList = heartend;
            heartcuttingNumber = hnumber;
        }
    }
}
