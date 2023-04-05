using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class PolygonShapeF : Shape
{
    public PolygonShapeF(SolidBrush brush) : base(brush)
    {
        Name = "FPOLY";
    }

    public override void Start(Point startPoint)
    {
        base.Start(startPoint);
        points.Add(startPoint);
    }

    public override void Draw(PaintEventArgs e, ComboBox a)
    {
        pen = new Pen(brush.Color,5);
        pen.DashStyle = (System.Drawing.Drawing2D.DashStyle)a.SelectedItem;
        e.Graphics.DrawPolygon(pen, points.ToArray());
        e.Graphics.FillPolygon(brush, points.ToArray());
    }

    public override void End()
    {
        base.End();
        if (points.Count > 2)
        {
            points.RemoveAt(points.Count - 1);
        }
    }
    public override void OGPoints()
    {
        for (int i = 0; i < points.Count; i++)
        {
            pointOG.Add(points[i]);
        }
    }
}

