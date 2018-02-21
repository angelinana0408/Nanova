using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MyMenu : UserControl
    {
        public MyMenu()
        {
            InitializeComponent();
        }

        private Image myImage;

        public Image MyImage
        {
            get
            {
                return myImage;
            }

            set
            {
                myImage = value;
                pictureBox1.Image = value;
            }
        }

        public string MyText
        {
            get
            {
                return myText;
            }

            set
            {
                myText = value;
                label1.Text = value;
            }
        }

        private string myText;
    }
}
