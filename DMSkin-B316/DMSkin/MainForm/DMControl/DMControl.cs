using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MainForm.Properties;


namespace QQMusic
{
    [ToolboxItem(true)]
    public partial class DMControl : DMSkin.Controls.DMControl
    {
        public DMControl()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.Selectable |
                ControlStyles.DoubleBuffer |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.Opaque, false);
            base.BackColor = Color.Transparent;
            this.UpdateStyles();
            if (items==null)
            {
                items = new DMControlItemCollection(this);
            }
        }
        [Editor(typeof(CommandCollectionEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public override DMSkin.Controls.DMControl.DMControlItemCollection Items
        {
            get
            {
                if (items == null)
                    items = new DMControlItemCollection(this);
                return items;
            }
        }
        public event EventHandler ItemClick;

        protected override void DrawItem(Graphics g, DMSkin.Controls.DMControlItem _item, Rectangle rectItem)
        {
            if (Items!=null&&Items.Count <= 0)
            {
                return;
            }
            //设置高质量插值法
            g.InterpolationMode = InterpolationMode.Bilinear;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            if (_item is Item)
            {
                Item it = (Item)_item;

                if (m_mouseOnItem!=null&&m_mouseOnItem.Equals(it)&&it.MouseBackColor!=null)
                {
                    g.FillRectangle(new SolidBrush(it.MouseBackColor),it.Bounds);
                    g.DrawString(it.Text, it.Font, new SolidBrush(Color.White), 50, it.Bounds.Y + 15);
                    if (it.Image != null)
                    {
                        g.DrawImage(it.HoverImage, it.Bounds.X + 17, it.Bounds.Y + 17, 21, 21);
                    }
                    if (it.RightImage != null)
                    {
                        g.DrawImage(it.RightHoverImage, it.Bounds.X + it.Bounds.Width - 17, it.Bounds.Y + 17,9,15);
                    }
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.White), it.Bounds);
                    g.DrawString(it.Text, it.Font, new SolidBrush(Color.Black), 50, it.Bounds.Y + 15);
                    if (it.Image != null)
                    {
                        g.DrawImage(it.Image, it.Bounds.X + 17, it.Bounds.Y + 17,21,21);
                    }
                    if (it.RightImage != null)
                    {
                        g.DrawImage(it.RightImage, it.Bounds.X + it.Bounds.Width - 17, it.Bounds.Y + 17, 9, 15);
                    }
                }
                g.DrawLine(new Pen(Color.FromArgb(236,236,236)), it.Bounds.X, it.Bounds.Y, it.Bounds.X+it.Bounds.Width, it.Bounds.Y);
                g.DrawLine(new Pen(Color.FromArgb(236, 236, 236)), it.Bounds.X, it.Bounds.Y + it.Bounds.Height, it.Bounds.X + it.Bounds.Width, it.Bounds.Y + it.Bounds.Height);
                
            }
            else if (_item is MusicItem)
            {
                MusicItem it = (MusicItem)_item;

                if (m_mouseOnItem != null && m_mouseOnItem.Equals(it) && it.MouseBackColor != null)
                {
                    g.FillRectangle(new SolidBrush(it.MouseBackColor), it.Bounds);
                    g.DrawString(it.MusicName, it.Font, new SolidBrush(Color.White),10, it.Bounds.Y + 18);
                    
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.White), it.Bounds);
                    g.DrawString(it.MusicName, it.Font, new SolidBrush(Color.Black), 10, it.Bounds.Y + 18);
                }
                g.DrawLine(new Pen(Color.FromArgb(236, 236, 236)), it.Bounds.X, it.Bounds.Y, it.Bounds.X + it.Bounds.Width, it.Bounds.Y);
                g.DrawLine(new Pen(Color.FromArgb(236, 236, 236)), it.Bounds.X, it.Bounds.Y + it.Bounds.Height, it.Bounds.X + it.Bounds.Width, it.Bounds.Y + it.Bounds.Height);

            }
            else if (_item is ImageItem)
            {
                ImageItem it = (ImageItem)_item;
                if (it.Image1 != null && it.Image2 != null && it.Image3 != null && it.Image4 != null)
                {
                    switch (it.SelectId)
                    {
                        case 1:
                            g.DrawImage(it.Image1, it.Bounds);
                            break;
                        case 2:
                            g.DrawImage(it.Image2, it.Bounds);
                            break;
                        case 3:
                            g.DrawImage(it.Image3, it.Bounds);
                            break;
                        case 4:
                            g.DrawImage(it.Image4, it.Bounds);
                            break;
                        default:
                            g.DrawImage(it.Image1, it.Bounds);
                            break;
                    }

                    g.FillEllipse(new SolidBrush(Color.White), it.Bounds1);
                    g.FillEllipse(new SolidBrush(Color.White), it.Bounds2);
                    g.FillEllipse(new SolidBrush(Color.White), it.Bounds3);
                    g.FillEllipse(new SolidBrush(Color.White), it.Bounds4);

                    g.FillEllipse(new SolidBrush(Color.FromArgb(13, 173, 81)), it.SelectBounds);
                }
                g.DrawLine(new Pen(Color.FromArgb(236, 236, 236)), it.Bounds.X, it.Bounds.Y, it.Bounds.X + it.Bounds.Width, it.Bounds.Y);
                g.DrawLine(new Pen(Color.FromArgb(236, 236, 236)), it.Bounds.X, it.Bounds.Y + it.Bounds.Height, it.Bounds.X + it.Bounds.Width, it.Bounds.Y + it.Bounds.Height);
            }
            else if (_item is LabelItem)
            {
                LabelItem it = (LabelItem)_item;
                if (it.Text != null)
                {
                    g.DrawLine(new Pen(Color.FromArgb(13, 173, 81), 3), it.Bounds.X + 3, it.Bounds.Y + 10, it.Bounds.X + 3, it.Bounds.Y + it.Bounds.Height-10);
                    g.DrawString(it.Text,it.Font, new SolidBrush(it.ForeColor), 5, it.Bounds.Y + 10);
                }
                g.DrawLine(new Pen(Color.FromArgb(236, 236, 236)), it.Bounds.X, it.Bounds.Y, it.Bounds.X + it.Bounds.Width, it.Bounds.Y);
                g.DrawLine(new Pen(Color.FromArgb(236, 236, 236)), it.Bounds.X, it.Bounds.Y + it.Bounds.Height, it.Bounds.X + it.Bounds.Width, it.Bounds.Y + it.Bounds.Height);
            }
            else if (_item is MusicListItem)
            {
                MusicListItem it = (MusicListItem)_item;
                   
                //可能包含1-3图片
                if (it.Image1!=null)
                {
                    if (it.MouseHover1)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(13, 173, 81)), it.Bounds1.X - 5, it.Bounds1.Y - 5, it.Bounds1.Width + 10, it.Bounds1.Height + 10);
                    }
                    g.DrawImage(it.Image1,it.Bounds1);
                    g.DrawString(it.Text1, it.Font, new SolidBrush(it.ForeColor), it.Bounds1.X +2, it.Bounds1.Y + it.Bounds1.Height + 5);
                    if (it.TextMore1!=null&&it.TextMore1!="")
                    {
                        g.DrawString(it.TextMore1,new Font("微软雅黑",9), new SolidBrush(Color.FromArgb(13,173,81)), it.Bounds1.X + 2, it.Bounds1.Y + it.Bounds1.Height + 25);
                    }
                }
                if (it.Image2 != null)
                {
                    if (it.MouseHover2)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(13, 173, 81)), it.Bounds2.X - 5, it.Bounds2.Y - 5, it.Bounds2.Width + 10, it.Bounds2.Height + 10);
                    }
                    g.DrawImage(it.Image2, it.Bounds2);
                    g.DrawString(it.Text2, it.Font, new SolidBrush(it.ForeColor),it.Bounds2.X+2, it.Bounds2.Y + it.Bounds2.Height + 5);
                    if (it.TextMore2 != null && it.TextMore2 != "")
                    {
                        g.DrawString(it.TextMore2, new Font("微软雅黑", 9), new SolidBrush(Color.FromArgb(13, 173, 81)), it.Bounds2.X + 2, it.Bounds2.Y + it.Bounds2.Height + 25);
                    }
                }
                if (it.Image3 != null)
                {
                    if (it.MouseHover3)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(13, 173, 81)), it.Bounds3.X - 5, it.Bounds3.Y - 5, it.Bounds3.Width + 10, it.Bounds3.Height + 10);
                    }
                    g.DrawImage(it.Image3, it.Bounds3);
                    g.DrawString(it.Text3, it.Font, new SolidBrush(it.ForeColor), it.Bounds3.X + 2, it.Bounds3.Y + it.Bounds3.Height + 5);
                    if (it.TextMore3 != null && it.TextMore3 != "")
                    {
                        g.DrawString(it.TextMore3, new Font("微软雅黑", 9), new SolidBrush(Color.FromArgb(13, 173, 81)), it.Bounds3.X + 2, it.Bounds3.Y + it.Bounds3.Height + 25);
                    }
                }
              }
            else if (_item is MvItem)//Mv项
            {
                MvItem it = (MvItem)_item;
                if (it.MouseHover)
                {
                    g.FillRectangle(new SolidBrush(Color.FromArgb(13, 173, 81)), it.Bounds.X - 2, it.Bounds.Y - 2, it.Bounds.Width+4,164);
                }
                if (it.Image!=null)
                {
                    g.DrawImage(it.Image, it.Bounds.X,it.Bounds.Y,it.Bounds.Width,160);
                }
                g.FillRectangle(new SolidBrush(Color.FromArgb(140, 0, 0, 0)), it.Bounds.X, it.Bounds.Y + 130, it.Bounds.Width, 30);
                g.DrawString(it.Text, it.Font, new SolidBrush(it.ForeColor), it.Bounds.X + 5, it.Bounds.Y + 135);
                   
                if (it.MouseHover)
                {
                     if (it.IsPlayHover)
                    {
                        //g.DrawImage(Resources.widget_playing_button, it.Bounds.X + it.Bounds.Width / 2 - it.Bounds.Width / 7, it.Bounds.Y +40, 60,60);
                        g.DrawImage(Resources.widget_playing_button_pressed, it.Bounds.X + it.Bounds.Width - 27, it.Bounds.Y + 132, 25, 25);
                        it.IsPlayHover = false;
                    }
                    else
                    {
                        g.DrawImage(Resources.widget_playing_button, it.Bounds.X + it.Bounds.Width - 27, it.Bounds.Y + 132, 25, 25);
                    }
                }
             }
            else
            {
                base.DrawItem(g,_item,rectItem);
            }
        }
        protected override void OnClick(EventArgs e)
        {
            foreach (var item in Items)
            {
                if (item is Item)
                {
                    Item it = (Item)item;
                    if (it.Bounds.Contains(m_ptMousePos))
                    {
                    if (ItemClick != null)
                    {
                        ItemClick(it, e);
                    }
                    break;
                }
               
              }
                if (item is MvItem)
                {
                    MvItem it = (MvItem)item;
                    if (new Rectangle(it.Bounds.X + it.Bounds.Width - 27, it.Bounds.Y + 132, 25, 25).Contains(m_ptMousePos))
                    {
                        if (ItemClick != null)
                        {
                            ItemClick(it, e);
                        }
                        break;
                    }
                }
               
            }
            base.OnClick(e);
        }
    
        protected override void OnMouseMove(MouseEventArgs e)
        {
            foreach (var item in Items)
            {
                if (item is MusicListItem)
                {
                    MusicListItem it = (MusicListItem)item;
                    it.MouseHover1 = false;
                    it.MouseHover2 = false;
                    it.MouseHover3 = false;
                    if (it.Bounds1.Contains(m_ptMousePos))
                    {
                        it.MouseHover1 = true;
                        this.Invalidate();
                        break;
                    }
                    if (it.Bounds2.Contains(m_ptMousePos))
                    {
                        it.MouseHover2 = true;
                        this.Invalidate(); 
                        break;
                    }
                    if (it.Bounds3.Contains(m_ptMousePos))
                    {
                        it.MouseHover3 = true;
                        this.Invalidate();
                        break;
                    }
                }
                if (item is MvItem)
                {
                    MvItem it = (MvItem)item;
                    it.MouseHover = false;
                    if (it.Bounds.Contains(m_ptMousePos))
                    {
                        if (new Rectangle(it.Bounds.X +it.Bounds.Width-27, it.Bounds.Y + 132,25,25).Contains(m_ptMousePos))//播放按钮区域
                        {
                            it.MouseHover = true;
                            it.IsPlayHover = true;
                            this.Invalidate();
                        }
                        else
                        {
                            it.MouseHover = true;
                            this.Invalidate();
                        }
                    }
                }
                if (item is ImageItem)
                {
                    ImageItem it = (ImageItem)item;
                    if (it.Bounds1.Contains(m_ptMousePos))
                    {
                        it.SelectBounds = it.Bounds1; it.SelectId = 1;
                        this.Invalidate();
                        break;
                    }
                    if (it.Bounds2.Contains(m_ptMousePos))
                    {
                        it.SelectBounds = it.Bounds2; it.SelectId = 2;
                        this.Invalidate();
                        break;
                    }
                    if (it.Bounds3.Contains(m_ptMousePos))
                    {
                        it.SelectBounds = it.Bounds3;
                        it.SelectId = 3;
                        this.Invalidate();

                        break;
                    }
                    if (it.Bounds4.Contains(m_ptMousePos))
                    {
                        it.SelectBounds = it.Bounds4; it.SelectId = 4;
                        this.Invalidate();

                        break;
                    }
                }
            }
            base.OnMouseMove(e);
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            foreach (var item in Items)
            {
                if (item is MusicItem)
                {
                    MusicItem it = (MusicItem)item;
                    if (it.Bounds.Contains(m_ptMousePos))
                    {
                        if (ItemClick != null)
                        {
                            ItemClick(it, e);
                        }
                        break;
                    }
                }
                if (item is MvItem)
                {
                    MvItem it = (MvItem)item;
                    if (it.Bounds.Contains(m_ptMousePos))
                    {
                        if (ItemClick != null)
                        {
                            ItemClick(it, e);
                        }
                        break;
                    }
                }
                if (item is MusicListItem)
                {
                    MusicListItem it = (MusicListItem)item;
                    if (it.Bounds1.Contains(m_ptMousePos))
                    {
                        it.ClickID = 1;
                        if (ItemClick != null)
                        {
                            ItemClick(it, e);
                        }
                        break;
                    }
                    if (it.Bounds2.Contains(m_ptMousePos))
                    {
                        it.ClickID = 2;
                        if (ItemClick != null)
                        {
                            ItemClick(it, e);
                        }
                        break;
                    }
                    if (it.Bounds3.Contains(m_ptMousePos))
                    {
                        it.ClickID = 3;
                        if (ItemClick != null)
                        {
                            ItemClick(it, e);
                        }
                        break;
                    }
                }
            }
            base.OnDoubleClick(e);
        }
    }
}
