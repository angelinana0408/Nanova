using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QQMusic
{
    public class ImageItem : DMSkin.Controls.DMControlItem
    {
        public Image Image1{ get; set; }
        public Image Image2 { get; set; }
        public Image Image3 { get; set; }
        public Image Image4 { get; set; }

        public Rectangle Bounds1 { get; set; }

        public Rectangle Bounds2 { get; set; }

        public Rectangle Bounds3 { get; set; }

        public Rectangle Bounds4 { get; set; }

        public Rectangle SelectBounds { get; set; }
        public int SelectId { get; set; }
    }
}
