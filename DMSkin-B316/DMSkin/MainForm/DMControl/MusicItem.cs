using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QQMusic
{
    public class MusicItem:DMSkin.Controls.DMControlItem
    {
        public Image Image { get; set; }

        public string WebUrl { get; set; }
        public string MusicName { get; set; }

        public Color MouseBackColor { get; set; }
    }
}
