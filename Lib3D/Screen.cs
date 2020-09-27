using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lib3D
{
    public class Screen
    {
        public Size Size { get; private set; }
        public RectangleF Rectangle { get; private set; }
        public Screen(Size sz, RectangleF r)
        {
            Size = sz;
            Rectangle = r;
        }
        public Point Real2Screen(PointF p)
        {
            return new Point((int)((p.X - Rectangle.X) / Rectangle.Width * Size.Width), (int)((Rectangle.Y - p.Y) / Rectangle.Height * Size.Height));
        }
    }
}
