using DMSkin;
using MainForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Metro : DMSkin.Main
    {
        public Metro()
        {
            InitializeComponent();
       
        }

        private void Metro_SizeChanged(object sender, EventArgs e)
        {
            //Text = Size.Width + "-"+Size.Height;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //MainForm.Opacity = Convert.ToDouble(trackBar1.Value) / 100;
        }

        private void metroButtonCloseLight1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void myPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
        }

        private void Metro_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White),3,3,Width-6,100);
        }

        private void Metro_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                //执行线程
                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(10);
                    Invoke(new Action(() =>
                    {
                        //执行委托
                    }));
                }
            }));
            thread.IsBackground = true;
            thread.Start();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Test");
           
        }

        private void metroButtonClose1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://user.qzone.qq.com/944095635");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://user.qzone.qq.com/944095635");
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Process.Start("http://user.qzone.qq.com/944095635");
        }

        private void 隐藏目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Size.Width==502&&Size.Height==261)
            {
                Size = new Size(502, 355);
            }
            else
            {
                Size = new Size(502, 261);
            }
        }

        private void metroButtonMin1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
    }
}
