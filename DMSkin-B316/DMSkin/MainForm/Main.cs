using MainForm;
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
    public partial class Main : DMSkin.Main
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            bootom = new Rectangle(new Point(0, 82), new Size(Width, Height));

            new Msg().Show();
        }

        #region 绘制窗体
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //绘制线条
            e.Graphics.DrawLine(Line, 0, 81, Width, 81);
           

            //绘制播放按钮
            switch (btn_play.State)
            {
                case MyButton.BtnState.Nol:
                    e.Graphics.DrawImage(btn_play.Nol, btn_play.Rectangle);
                    break;
                case MyButton.BtnState.Down:
                    e.Graphics.DrawImage(btn_play.Down, btn_play.Rectangle);
                    break;
                default:
                    break;
            }
            //媒体按钮
            switch (btn_media.State)
            {
                case MyButton.BtnState.Nol:
                    e.Graphics.DrawImage(btn_media.Nol, btn_media.Rectangle);
                    break;
                case MyButton.BtnState.Down:
                    e.Graphics.DrawImage(btn_media.Down, btn_media.Rectangle);
                    break;
                default:
                    break;
            }

            //设置按钮
            switch (btn_set.State)
            {
                case MyButton.BtnState.Nol:
                    e.Graphics.DrawImage(btn_set.Nol, btn_set.Rectangle);
                    break;
                case MyButton.BtnState.Down:
                    e.Graphics.DrawImage(btn_set.Down, btn_set.Rectangle);
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 窗体事件
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            //播放按钮的点击事件
            if (btn_play.Rectangle.Contains(e.Location))
            {
                btn_play.State = MyButton.BtnState.Down;
                btn_media.State = MyButton.BtnState.Nol;
                btn_set.State = MyButton.BtnState.Nol;
            }
            else if (btn_media.Rectangle.Contains(e.Location))
            {
                btn_media.State = MyButton.BtnState.Down;
                btn_play.State = MyButton.BtnState.Nol;
                btn_set.State = MyButton.BtnState.Nol;
            }
            else if (btn_set.Rectangle.Contains(e.Location))
            {
                btn_set.State = MyButton.BtnState.Down;
                btn_play.State = MyButton.BtnState.Nol;
                btn_media.State = MyButton.BtnState.Nol;
            }

            Invalidate(btn_play.Rectangle);
            Invalidate(btn_set.Rectangle);
            Invalidate(btn_media.Rectangle);

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            //按钮的按下事件 - 此区域不能拖动窗体
            if (btn_play.Rectangle.Contains(e.Location) || btn_media.Rectangle.Contains(e.Location) || btn_set.Rectangle.Contains(e.Location))
            {
                return;
            }
            base.OnMouseDown(e);
        }
        #endregion

        #region 属性
        Rectangle bootom;//底部区域
        Pen Line = new Pen(Color.FromArgb(216, 216, 216), 1);//线条颜色


        //按钮组
        MyButton btn_play = new MyButton(40, 0, 90, 80, Resources.top_play_nol, Resources.top_play_hover, Resources.top_play_down, MyButton.BtnState.Down);
        MyButton btn_media = new MyButton(140, 0, 90, 80, Resources.top_media_nol, Resources.top_media_hover, Resources.top_media_down, MyButton.BtnState.Nol);
        MyButton btn_set = new MyButton(240, 0, 90, 80, Resources.top_set_nol, Resources.top_set_hover, Resources.top_set_down, MyButton.BtnState.Nol);
        #endregion
    }
}
