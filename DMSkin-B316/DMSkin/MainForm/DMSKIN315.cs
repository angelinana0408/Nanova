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
    public partial class DMSKIN315 : DMSkin.DMSkinForm
    {
        public DMSKIN315()
        {
            InitializeComponent();
        }

        private void DMSKIN315_Load(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (DM_SystemButtonThemeColor == DMColor.Dark)
            {
                DM_SystemButtonThemeColor = DMColor.Ligth;
                BackColor = Color.Black;
            }
            else
            {
                DM_SystemButtonThemeColor = DMColor.Dark;
                BackColor = Color.White;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DM_SystemButtonShowMax = DM_SystemButtonShowMax == true ? false : true;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DM_SystemDrawLine = DM_SystemDrawLine == true ? false : true;
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            DM_Shadow = DM_Shadow == true ? false : true;
            Invalidate();

            base.Invalidate();

        }
    }
}
