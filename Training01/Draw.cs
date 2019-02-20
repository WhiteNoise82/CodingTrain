using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Training01
{
    class Draw
    {
        public void Paint(Graphics graphics)
        {
            Rectangle rectangle = new Rectangle(50, 100, 150, 150);
            graphics.DrawEllipse(Pens.Black, rectangle);
            graphics.DrawRectangle(Pens.Red, rectangle);
        }
    }
}
