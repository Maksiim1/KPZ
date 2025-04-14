using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Square : Shape
    {
        public Square(IRenderer renderer, double x, double y, double side) : base(renderer, x, y, side)
        {
        }

        public override void Draw()
        {
            renderer.RenderShape("Square", x, y, size);
        }
    }
}
