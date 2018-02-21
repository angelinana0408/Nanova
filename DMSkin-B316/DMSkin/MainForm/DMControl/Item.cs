using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QQMusic
{
    public class Item : DMSkin.Controls.DMControlItem
    {
        public Image Image { get; set; }

        public Image HoverImage { get; set; }

        public Image RightImage { get; set; }
        public string Text { get; set; }

        public Color MouseBackColor { get; set; }

        public System.Drawing.Image RightHoverImage { get; set; }

    }
}
