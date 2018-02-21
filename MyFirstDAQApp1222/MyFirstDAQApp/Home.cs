using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFirstDAQApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void CustomMethod_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            Form1 CustomRun = new Form1();
            CustomRun.Show();
        }
    }
}
