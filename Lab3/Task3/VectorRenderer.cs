using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Point = System.Windows.Point;

namespace Task3
{
    public class VectorRenderer : IRenderer
    {
        private TextBlock output;
        private Canvas canvas;

        public VectorRenderer(TextBlock output, Canvas canvas)
        {
            this.output = output;
            this.canvas = canvas;
        }

        public void RenderShape(string shape, double x, double y, double size)
        {
            output.Text += $"Drawing {shape} as vectors\n";

            if (shape == "Circle")
            {
                Ellipse ellipse = new Ellipse
                {
                    Width = size * 2,
                    Height = size * 2,
                    Stroke = Brushes.Blue,
                    StrokeThickness = 2
                };
                Canvas.SetLeft(ellipse, x - size);
                Canvas.SetTop(ellipse, y - size);
                canvas.Children.Add(ellipse);
            }
            else if (shape == "Square")
            {
                Rectangle rectangle = new Rectangle
                {
                    Width = size,
                    Height = size,
                    Stroke = Brushes.Blue,
                    StrokeThickness = 2
                };
                Canvas.SetLeft(rectangle, x - size / 2);
                Canvas.SetTop(rectangle, y - size / 2);
                canvas.Children.Add(rectangle);
            }
            else if (shape == "Triangle")
            {
                Polygon triangle = new Polygon
                {
                    Points = new PointCollection
                    {
                        new Point(x, y - size),
                        new Point(x - size, y + size),
                        new Point(x + size, y + size)
                    },
                    Stroke = Brushes.Blue,
                    StrokeThickness = 2
                };
                canvas.Children.Add(triangle);
            }
        }
    }
}