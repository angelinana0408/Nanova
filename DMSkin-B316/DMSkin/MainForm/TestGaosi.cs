using MainForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainForm
{
    public partial class TestGaosi : DMSkin.DUIMain
    {
        public TestGaosi()
        {
            InitializeComponent();

        }

       

        private void MClick(object sender, EventArgs e)
        {
            Close();
        }
        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Print((TrackBar)sender);
            Alpha = trackBar1.Value;
            Print();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Print((TrackBar)sender);
            AlphaGauss = trackBar2.Value;
            Print();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AlphaGauss = trackBar2.Value;
            AlphaIsGauss = checkBox1.Checked;
            Print();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Print(button1);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Print(button1);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Print(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    BackgroundImage = Image.FromFile(op.FileName);
                    Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("格式错误!");
                }
            }
        }


    }
}
