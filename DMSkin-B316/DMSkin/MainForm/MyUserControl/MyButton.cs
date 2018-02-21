using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MainForm
{
    class MyButton
    {
        public enum BtnState
        {
           Nol,Down
        }

        BtnState state;
        Image nol;
        Image hover;
        Image down;
        Rectangle rectangle;

        public MyButton(int v1, int v2, int v3, int v4, Bitmap nol, Bitmap hover, Bitmap down,BtnState state)
        {
            rectangle = new Rectangle(new Point(v1,v2),new Size(v3,v4));
           
            this.nol = nol;
            this.hover = hover;
            this.down = down;

            this.state = state;
        }

        public Image Down
        {
            get
            {
                return down;
            }

            set
            {
                down = value;
            }
        }

        public Image Hover
        {
            get
            {
                return hover;
            }

            set
            {
                hover = value;
            }
        }

        public Image Nol
        {
            get
            {
                return nol;
            }

            set
            {
                nol = value;
            }
        }

        public BtnState State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public Rectangle Rectangle
        {
            get
            {
                return rectangle;
            }

            set
            {
                rectangle = value;
            }
        }
    }
}
