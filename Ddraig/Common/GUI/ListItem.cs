using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.GUI
{
    public abstract class ListItem : Common.Graphics.IDrawable
    {
        public abstract int Height { get; }
        public abstract int Width { get; }
        public abstract void Draw(Common.Graphics.Canvas canvas);
    }
}
