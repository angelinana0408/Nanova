using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QQMusic
{
    public class MusicListItem : DMSkin.Controls.DMControlItem
    {
        public string WebUrl1 { get; set; }
        public string WebUrl2 { get; set; }
        public string WebUrl3 { get; set; }
        public bool MouseHover1 { get; set; }
        public bool MouseHover2 { get; set; }
        public bool MouseHover3 { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string TextMore1 { get; set; }
        public string TextMore2 { get; set; }
        public string TextMore3 { get; set; }
        
        public Image Image1 { get; set; }
        public Image Image2 { get; set; }

        public Image Image3 { get; set; }

        public Rectangle Bounds1 { get; set; }
        public Rectangle Bounds2 { get; set; }
        public Rectangle Bounds3 { get; set; }

        public string Text { get; set; }

        public int ClickID { get; set; }
    }
}
