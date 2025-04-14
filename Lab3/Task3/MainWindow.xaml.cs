using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
namespace Task3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private TextBlock outputTextBlock = null!;
    private Canvas drawingCanvas = null!;

    public MainWindow()
    {
        InitializeComponent();
        CreateUI();
        DemonstrateShapes();
    }

    private void CreateUI()
    {
        Grid mainGrid = new Grid();
        mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        mainGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        Content = mainGrid;

        drawingCanvas = new Canvas
        {
            Background = Brushes.WhiteSmoke
        };
        Grid.SetRow(drawingCanvas, 0);
        mainGrid.Children.Add(drawingCanvas);

        outputTextBlock = new TextBlock
        {
            FontFamily = new System.Windows.Media.FontFamily("Consolas"),
            Margin = new Thickness(10),
            TextWrapping = TextWrapping.Wrap
        };

        ScrollViewer scrollViewer = new ScrollViewer
        {
            Content = outputTextBlock,
            VerticalScrollBarVisibility = ScrollBarVisibility.Auto
        };
        Grid.SetRow(scrollViewer, 1);
        mainGrid.Children.Add(scrollViewer);
    }

    private void DemonstrateShapes()
    {
        IRenderer vectorRenderer = new VectorRenderer(outputTextBlock, drawingCanvas);
        IRenderer rasterRenderer = new RasterRenderer(outputTextBlock, drawingCanvas);

        Shape circleVector = new Circle(vectorRenderer, 100, 100, 50);
        Shape squareVector = new Square(vectorRenderer, 250, 100, 80);
        Shape triangleVector = new Triangle(vectorRenderer, 400, 100, 50);

        Shape circleRaster = new Circle(rasterRenderer, 100, 250, 50);
        Shape squareRaster = new Square(rasterRenderer, 250, 250, 80);
        Shape triangleRaster = new Triangle(rasterRenderer, 400, 250, 50);

        AppendText("Vector rendering:");
        circleVector.Draw();
        squareVector.Draw();
        triangleVector.Draw();

        AppendText("\nRaster rendering:");
        circleRaster.Draw();
        squareRaster.Draw();
        triangleRaster.Draw();
    }

    private void AppendText(string text)
    {
        outputTextBlock.Text += text + "\n";
    }
}