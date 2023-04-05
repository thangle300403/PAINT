using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

public class Shape
{
    public Point startPoint;
    public Point endPoint;
    public Pen pen;
    public SolidBrush brush;
    public List<Point> points = new List<Point>();
    public bool isDrawing = false;
    public string Name;
    public List<Point> pointOG = new List<Point>();
    public List<Shape> Shapes = new List<Shape>();
    public int IDX = 0;
    public Shape(Pen pen)
    {
        this.pen = pen;
    }
    public Shape(SolidBrush brush)
    {
        this.brush = brush;
    }
    public virtual void Start(Point startPoint)
    {
        this.startPoint = startPoint;
        this.endPoint = startPoint;
        this.isDrawing = true;
    }
    public virtual void Draw(PaintEventArgs e, ComboBox a)
    {

    }
    public virtual void End()
    {
        this.isDrawing = false;
    }
    public virtual void OGPoints()
    {
        pointOG.Add(startPoint);
        pointOG.Add(endPoint);
    }
}
