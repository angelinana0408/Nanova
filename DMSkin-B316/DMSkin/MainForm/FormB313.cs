using DMSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainForm
{
    public partial class FormB313 : DMSkin.Main
    {
        public FormB313()
        {
            InitializeComponent();

            new MainForm.Main().Show();
        }

        private void FormB311_Load(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader("d://1.txt", Encoding.Default);
            //String line;
            //while ((line = sr.ReadLine()) != null)
            //{
            //    if (line.Contains("name"))
            //    {
            //        textBox1.Text += "\r\n" + line;
            //    }
            //}
        }

        private void dmIcon1_Click(object sender, EventArgs e)
        {

        }

        private void dmControl4_ItemClick(object sender, EventArgs e)
        {
            if (sender is DMControlGridItem)
            {
                MessageBox.Show("单击" + ((DMSkin.DMControlGridItem)sender).ClickID);
                //如果是用MessageBox。单击双击 同时打开，。只能 完成单击事件。因为阻塞了
            }
            if (sender is DMControlImageItem)
            {
                MessageBox.Show("单击" + ((DMSkin.DMControlImageItem)sender).ID);
            }
            if (sender is DMControlMenuItem)
            {
                MessageBox.Show("单击" + ((DMSkin.DMControlMenuItem)sender).ID);
            }
        }

        private void dmControl4_ItemDoubleClick(object sender, EventArgs e)
        {
            if (sender is DMControlGridItem)
            {
                //MessageBox.Show("双击" + ((DMSkin.DMControlGridItem)sender).ClickID);

            }
        }
    }
}
