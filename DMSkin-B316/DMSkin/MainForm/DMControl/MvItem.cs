using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QQMusic
{
    public class MvItem : DMSkin.Controls.DMControlItem
    {
        public string Text { get; set; }
        public Image Image { get; set; }

        public string url { get; set; }

        public bool MouseHover { get; set; }


        public bool IsPlayHover { get; set; }
    }
}
