using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer, double x, double y, double size) : base(renderer, x, y, size)
        {
        }

        public override void Draw()
        {
            renderer.RenderShape("Triangle", x, y, size);
        }
    }
}
