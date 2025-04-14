using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Shape
    {
        protected IRenderer renderer;
        protected double x, y;
        protected double size;

        public Shape(IRenderer renderer, double x, double y, double size)
        {
            this.renderer = renderer;
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public abstract void Draw();
    }
}
