using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task3
{
    public class RasterRenderer : IRenderer
    {
        private TextBlock output;
        private Canvas canvas;

        public RasterRenderer(TextBlock output, Canvas canvas)
        {
            this.output = output;
            this.canvas = canvas;
        }

        public void RenderShape(string shape, double x, double y, double size)
        {
            output.Text += $"Drawing {shape} as pixels\n";

            if (shape == "Circle")
            {
                Ellipse ellipse = new Ellipse
                {
                    Width = size * 2,
                    Height = size * 2,
                    Stroke = Brushes.Red,
                    StrokeThickness = 2,
                    StrokeDashArray = new DoubleCollection { 4, 2 }
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
                    Stroke = Brushes.Red,
                    StrokeThickness = 2,
                    StrokeDashArray = new DoubleCollection { 4, 2 }
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
                    Stroke = Brushes.Red,
                    StrokeThickness = 2,
                    StrokeDashArray = new DoubleCollection { 4, 2 }
                };
                canvas.Children.Add(triangle);
            }
        }
    }
}