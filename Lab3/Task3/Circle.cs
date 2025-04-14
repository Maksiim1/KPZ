using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Circle : Shape
    {
        public Circle(IRenderer renderer, double x, double y, double radius) : base(renderer, x, y, radius)
        {
        }

        public override void Draw()
        {
            renderer.RenderShape("Circle", x, y, size);
        }
    }
}
